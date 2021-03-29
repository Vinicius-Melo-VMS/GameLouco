using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animation))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(CapsuleCollider2D))]
//[RequireComponent(typeof(SYSVDMA))] temporariamente desativado <<<---- SYS DE COMBATE NãO PRESSODO DIZER O QUE CONTEM ESSE SYS
public class pbv2f : MonoBehaviour
{

    [Header("Componentes")]
    public Rigidbody2D rb2d;
    [SerializeReference] private Animation anim;
    [SerializeReference] private SpriteRenderer sprite;
    [SerializeReference] private Collider2D col2d;
    [Header("Verificador do Chão")]
    public LayerMask graundMasck;
    public Transform graundCheck;
    // public float RaioDoGizmo; rerificador do warp
    public bool OnGrald;
    public float AfastCheckGrald;
    public float afastamentoCh;
    [Header("Movimento")]
    public float Speed = 5;
    public int direction = 1;  ///todo: Flip
    public float jumpForce = 10f;
    public bool JumpDual = false;
    bool InpEscape = false;
    public bool muvestop = false;
    [Header("Ladder")]
    public float climbSpeed = 3;                //velocidade de subida na escada
    public LayerMask ladderMask;                //máscara de camada da escada
    public bool climbing;                       //identifica se jogador está escalando a escada
    public float checkRadius = 0.3f;            //raio de checagem com a escada
    private bool clearInputs;



    void starCheck1()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animation>();
        sprite = GetComponent<SpriteRenderer>();
        col2d = GetComponent<Collider2D>();
        graundCheck = GameObject.Find("GraldCheck").transform;
    }
    private void Awake()
    {
        starCheck1();
    }

    void Start()
    {


    }
    private void Update()
    {
        ChecKPhisics1();
        ChackInput1();
        //MovimentoBasePleyer(); //? para avaliação desativado


    }

    private void FixedUpdate()
    {
        T2();
        MovimentoBasePleyer1();

    }



    bool T1()
    {

        return col2d.IsTouchingLayers(ladderMask);

    }
    public  float alinhaEscada = 0.5f;
    void T2()
    {
        bool up = Physics2D.OverlapCircle(rb2d.transform.position, checkRadius, ladderMask);
        bool dow = Physics2D.OverlapCircle(rb2d.transform.position + new Vector3(0, -1), checkRadius, ladderMask) ;


        if (inputUPDw != 0 && T1())
        {
            climbing = true;
            muvestop = true;
            rb2d.isKinematic = true;


            float xPos = (int)transform.position.x;
            xPos = xPos + (alinhaEscada * Mathf.Sign(xPos));
            transform.position = new Vector2(xPos, transform.position.y);

        }
        if (climbing)
        {
            if (!up && inputUPDw >= 0)
            {
                T3();
                return;
            }

            if (!dow && inputUPDw <= 0)
            {
                T3();
                return;
            }

            float y = inputUPDw * climbSpeed;
            rb2d.velocity = new Vector2(0, y);

            if (InpSpace) {
                col2d.isTrigger = true;
                T3();
                float x = inputUPDw;
                if(inputUPDw != 0)
                {
                    x = inputUPDw > 0 ? 1 : -1;
                    if(x * inputUPDw < 0)
                    {
                        flip();
                    }
                }
            }
        }
       
        

    }
    void T3()
    {
        climbing = false;
        rb2d.isKinematic = false;
        muvestop = false;
    }
    void T4() { }


    public void MovimentoBasePleyer1()
    {

        if (muvestop)
            return;
        //  float XdJ;


        rb2d.velocity = new Vector2(inputLeft * Speed, rb2d.velocity.y);
        if (inputLeft * direction < 0f) { flip(); }


        if (InpSpace)
        {
            if (OnGrald)
            {
                DoJump1();
                JumpDual = true;

                Debug.Log("P1");
            }
            else if (!OnGrald && JumpDual)
            {
                DoJump1();
                JumpDual = false;

                Debug.Log("P2");
            }

        }
       
        //! (PERIGO!!! METODO JUMP NÃO ESATA FUCIONADO COMO DEVERIA) Tera que fazer um metodo proprio otulizando do forom 
        //TODO: problama estava  na movimentação
        void DoJump1()
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
            rb2d.AddForce(Vector2.up * jumpForce);

        }
    }

    void flip()
    {
        direction *= -1;                        //Inverte o valor da direção     
        Vector3 scale = transform.localScale;   //Armazena a escala do jogador
        scale.x *= -1;                          //No valor armazena, inverte o valor da escala em X
        transform.localScale = scale;           //Atualiza a escala do jogador de acordo com o novo Vector3 armazenado
    }

    bool InpD = false, InpSpace = false, InpA = false, InpS = false, InpF = false, InpE = false;
    float inputUPDwJ, inputLeft, inputLeftJ;
    public float inputUPDw;
    public void ChackInput1()
    {
        //todo: Inputs Geral
        {
            //todo: Opção mais logica do Input PC (topo BOOL)
            InpE = (Input.GetKeyDown(KeyCode.E));
            InpF = (Input.GetKeyDown(KeyCode.F));
            InpA = (Input.GetKeyDown(KeyCode.A));
            InpS = (Input.GetKeyDown(KeyCode.S));
            InpD = (Input.GetKeyDown(KeyCode.D));
            InpSpace = (Input.GetKeyDown(KeyCode.Space));



            InpEscape = (Input.GetKeyDown(KeyCode.Escape));
            //todo: Movimetno (tipo float)
            inputUPDw = Input.GetAxis("Vertical");
            inputLeft = Input.GetAxis("Horizontal");

            //Todo: Opção mais logica do Input Joystick Xbox

            //inputUPDwJ = Input.GetAxis("VerticalJ");
            //  inputLeftJ = Input.GetAxis("HorizontalJ");


        }


    }

    void ChecKPhisics1()
    {
        OnGrald = false;

        RaycastHit2D t1 = Raycast(graundCheck.position + new Vector3(-AfastCheckGrald, 0), Vector2.down, afastamentoCh, graundMasck);
        RaycastHit2D t2 = Raycast(graundCheck.position + new Vector3(AfastCheckGrald, 0), Vector2.down, afastamentoCh, graundMasck);
        // OnGrald = Physics2D.OverlapCircle(graundCheck.position, afastamentoCh, graundMasck);


        if (t1 || t2)

        {
            OnGrald = true;

            JumpDual = false;
        }

    }

    public void OnDrawGizmos()
    {
        ChecKPhisics1();
        Gizmos.DrawWireSphere(rb2d.transform.position + new Vector3(0, -0.5f ), checkRadius);
        Gizmos.DrawWireSphere(rb2d.transform.position, checkRadius);
        Gizmos.color = Color.red;

    }


    public RaycastHit2D Raycast(Vector2 origin, Vector2 Direction, float Distacia, LayerMask mask, bool ativador = true)
    {

        RaycastHit2D hit = Physics2D.Raycast(origin, Direction, Distacia, mask);

        if (ativador)
        {
            Color calor = hit ? Color.red : Color.green;

            Debug.DrawRay(origin, Direction * Distacia, calor);
        }

        return hit;

    }
    

}
