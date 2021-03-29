using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animation))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(CapsuleCollider2D))]
//[RequireComponent(typeof(SYSVDMA))] temporariamente desativado <<<---- SYS DE COMBATE NãO PRESSODO DIZER O QUE CONTEM ESSE SYS
public class PleyerBaseV2 : MonoBehaviour
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
    public float Speed;
    public float jumpForce = 10f;
    public bool JumpDual = false;
    bool InpEscape = false;
    bool InpEscapef = false;
    public int direction = 1;




    void starCheck()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animation>();
        sprite = GetComponent<SpriteRenderer>();
        col2d = GetComponent<Collider2D>();
        graundCheck = GameObject.Find("GraldCheck").transform;
    }
    private void Awake()
    {
        starCheck();
    }

    void Start()
    {


    }
    private void Update()
    {

        ChackInput();
        //MovimentoBasePleyer(); //? para avaliação desativado
        ChecKPhisics();

    }

    private void FixedUpdate()
    {
        MovimentoBasePleyer();
        //ChecKPhisics();
    }

    public void MovimentoBasePleyer()
    {

        //  float XdJ;
        float Xd  = inputUPDw;
        float XdJ = inputUPDwJ;
        rb2d.velocity = new Vector2(inputUPDw * Speed, rb2d.velocity.y);
        if (inputUPDw * direction < 0f) { flip(); }


        if (InpSpace)
        {
            if (OnGrald)
            {
                DoJump();
                JumpDual = true;

                Debug.Log("P1");
            }
            else if (!OnGrald && JumpDual)
            {
                DoJump();
                JumpDual = false;

                Debug.Log("P2");
            }

        }
        void flip()
        {
            direction *= -1;                        //Inverte o valor da direção     
            Vector3 scale = transform.localScale;   //Armazena a escala do jogador
            scale.x *= -1;                          //No valor armazena, inverte o valor da escala em X
            transform.localScale = scale;           //Atualiza a escala do jogador de acordo com o novo Vector3 armazenado
        }
        //! (PERIGO!!! METODO JUMP NÃO ESATA FUCIONADO COMO DEVERIA) Tera que fazer um metodo proprio otulizando do forom 
        //TODO: problama estava  na movimentação
        void DoJump()
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
            rb2d.AddForce(Vector2.up * jumpForce);

        }
    }



    bool InpD = false, InpSpace = false, InpA = false, InpS = false, InpF = false, InpE = false;
    float inputUPDw, inputUPDwJ, inputLeft, inputLeftJ;

    public void ChackInput()
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
            inputLeft = Input.GetAxis("Vertical");
            inputUPDw = Input.GetAxis("Horizontal");

            //Todo: Opção mais logica do Input Joystick Xbox

            inputLeftJ = Input.GetAxis("VerticalJ");
            inputUPDwJ = Input.GetAxis("HorizontalJ");


        }


    }

    void ChecKPhisics()
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
        ChecKPhisics();
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
