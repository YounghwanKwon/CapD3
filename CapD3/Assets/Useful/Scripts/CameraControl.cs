using UnityEngine;

namespace Complete
{
    public class CameraControl : MonoBehaviour
    {
        public float m_DampTime = 0.2f;                 
        public float m_ScreenEdgeBuffer = 4f;          
        public float m_MinSize = 6.5f;                 
        [HideInInspector] public Transform[] m_Targets; 
        [SerializeField] private GameObject oldtank;
        private GameObject mainobject;
        [SerializeField] private GameObject[] nextobj;
        public static int nextcounter;
        [SerializeField] private GameObject bindingobj;
        private GameObject binder;

        private Camera m_Camera;                       
        private float m_ZoomSpeed;                      
        private Vector3 m_MoveVelocity;              
        private Vector3 m_DesiredPosition;            

        private void Start()
        {
            mainobject = new GameObject();
            mainobject = oldtank;
            nextcounter = 0;
            //Invoke("setmainobj", 2.5f);
        }
        private void Awake ()
        {
            m_Camera = GetComponentInChildren<Camera> ();
        }


        private void FixedUpdate ()
        {
            // Move the camera towards a desired position.
            Move ();

            // Change the size of the camera based.
            Zoom ();
        }
        public void setmainobj()
        {
            if(bindingobj)
            {
                Debug.Log("binder if on");
                binder = Instantiate(bindingobj, oldtank.transform);
                binder.SetActive(true);
                binder.transform.parent = null;
            }
            else
                Debug.Log("no binder err");

            if (nextcounter < nextobj.Length)
            {
                mainobject = nextobj[nextcounter];
                nextcounter++;
            }
            else
                Debug.Log("no nextobj err");

            Invoke("setbacktotank", 2f);
        }
        public void setbacktotank()
        {
            if (oldtank)
            {
                mainobject = oldtank;
                Invoke("destorybinder", 1f);
            }
        }
        public void destorybinder()
        {
            Destroy(binder);
        }


        private void Move()
        {
            if (mainobject != null)
            {
                FindPosition();

                transform.position = Vector3.SmoothDamp(transform.position, m_DesiredPosition, ref m_MoveVelocity, m_DampTime);
            }
        }


        private void FindAveragePosition()
        {
            Vector3 averagePos = new Vector3();
            int numTargets = 0;

            for (int i = 0; i < m_Targets.Length; i++)
            {
                if (!m_Targets[i].gameObject.activeSelf)
                    continue;

                averagePos += m_Targets[i].position;
                numTargets++;
            }

            if (numTargets > 0)
                averagePos /= numTargets;

            averagePos.y = transform.position.y;

            m_DesiredPosition = averagePos;
        }
        private void FindPosition()
        {
            Vector3 BackPos = new Vector3();
            int numTargets = 0;

            for (int i = 0; i < m_Targets.Length; i++)
            {
                if (!m_Targets[i].gameObject.activeSelf)
                    continue;

                BackPos += m_Targets[i].position;
                numTargets++;
            }

            if (numTargets > 0)
                BackPos /= numTargets;

            BackPos.y = transform.position.y;

            m_DesiredPosition = new Vector3(mainobject.transform.position.x, 0, mainobject.transform.position.z);
        }


        private void Zoom ()
        {
            float requiredSize = FindRequiredSize();
            m_Camera.orthographicSize = Mathf.SmoothDamp (m_Camera.orthographicSize, requiredSize, ref m_ZoomSpeed, m_DampTime);
        }


        private float FindRequiredSize ()
        {
            Vector3 desiredLocalPos = transform.InverseTransformPoint(m_DesiredPosition);

            float size = 0f;

            for (int i = 0; i < m_Targets.Length; i++)
            {
                if (!m_Targets[i].gameObject.activeSelf)
                    continue;

                Vector3 targetLocalPos = transform.InverseTransformPoint(m_Targets[i].position);

                Vector3 desiredPosToTarget = targetLocalPos - desiredLocalPos;

                size = Mathf.Max(size, Mathf.Abs(desiredPosToTarget.y));

                size = Mathf.Max(size, Mathf.Abs(desiredPosToTarget.x) / m_Camera.aspect);
            }

            size += m_ScreenEdgeBuffer;

            size = Mathf.Max (size, m_MinSize);

            return size;
        }


        public void SetStartPositionAndSize ()
        {
            FindAveragePosition ();

            transform.position = m_DesiredPosition;

            m_Camera.orthographicSize = FindRequiredSize ();
        }
    }
}