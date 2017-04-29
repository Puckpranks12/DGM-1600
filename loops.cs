public class WhileLoop : MonoBehaviour
{
    int alarmsBlaring = 0;
    
        void Start ()
    {
        while(alarmsBlaring < 10)
        {
            Debug.Log ("Stay in the Shadows! The Storm Troopers are searching for you!");
            alarmsBlaring++;
        }
    }
}



public class ForLoop : MonoBehaviour
{
    int enemies = 10;
        
    void Start ()
    {
        for(int i = 0; i < enemies; i++)
        {
            Debug.Log("Enemies Detected: " + i);
        }
    }
}