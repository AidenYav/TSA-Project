using UnityEngine;
using UnityEngine.UI;
public class ExpressionAnimationManager : MonoBehaviour
{

    [SerializeField]
    private Animator orionAnimation, carinaAnimation, solAnimation;


    private string BackgroundPath = "Backgrounds";
    public Image background;



    public void playExpression(string tag){
        //Split the tag
        string[] splitTag = tag.Split('_');
        //Ensures that the tag is approprietly parsed
        if (splitTag.Length != 2){
            Debug.Log("Error with tag, could not parse in Expression Animation Manager: " + tag);
        }
        else{
            string name = splitTag[0].Trim();
            string animation = splitTag[1].Trim();
            switch (name){
                case "Orion":
                orionAnimation.Play(tag);
                break;
                case "Carina":
                carinaAnimation.Play(tag);
                break;
                case "Sol":
                solAnimation.Play(tag);
                break;
                default:
                Debug.Log("Unknown character: " + name + "\nUnknown Animation: " + tag);
                break;
            }
        }
    }
    

    public void playBackground(string tag){
        string path = BackgroundPath + "/" + tag;
        Texture2D texture = Resources.Load<Texture2D>(path);
        if (texture == null){
            Debug.Log(path + " not found!");
        }else{
            Debug.Log("Path found!");
            
            // Create a sprite from the Texture2D
            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
            background.sprite = sprite;
        }
    }
}
