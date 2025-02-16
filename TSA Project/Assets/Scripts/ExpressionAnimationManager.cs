using UnityEngine;

public class ExpressionAnimationManager : MonoBehaviour
{

    [SerializeField]
    private Animator orionAnimation, carinaAnimation;

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
                    default:
                    Debug.Log("Unknown character: " + name + "\nUnknown Animation: " + tag);
                    break;
                }
            }
    }
}
