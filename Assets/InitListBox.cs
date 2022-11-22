using AirFishLab.ScrollingList;
using UnityEngine;
using UnityEngine.UI;

// The box used for displaying the content
// Must be inherited from the class ListBox
public class InitListBox : ListBox
{
    [SerializeField]
    private Image _contentText;
    RectTransform _buttonGameobject;
    // This function is invoked by the `CircularScrollingList` for updating the list content.
    // The type of the content will be converted to `object` in the `IntListBank` (Defined later)
    // So it should be converted back to its own type for being used.
    // The original type of the content is `int`.
    protected override void UpdateDisplayContent(object content)
    {
        _contentText.sprite = (Sprite)content;

    }
    private void Start()
    {
        _buttonGameobject = transform.GetComponent<RectTransform>();
    }
   /* private void Update()
    {
        int index = transform.GetSiblingIndex();
        if (index == 0 || index == 2)
        {
            _buttonGameobject.sizeDelta = new Vector2(160, 415);
*//*            var rotationVector = transform.rotation.eulerAngles;
            if (transform.position.x > 0)
            {
                rotationVector.y = 12;
            }
            else
            {
                rotationVector.y = -12;
            }
            transform.rotation = Quaternion.Euler(rotationVector);*//*
        }
        if (index == 1 || index == 3)
        {
            _buttonGameobject.sizeDelta = new Vector2(160, 390);
*//*            var rotationVector = transform.rotation.eulerAngles;
            if (transform.position.x > 0)
            {
                rotationVector.y = 5;
            }
            else
            {
                rotationVector.y = -5;
            }
            transform.rotation = Quaternion.Euler(rotationVector);*//*
        }
        if (index == 4)
        {
            _buttonGameobject.sizeDelta = new Vector2(180, 380);
*//*            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.y = 0;
            transform.rotation = Quaternion.Euler(rotationVector);*//*
        }
    }*/
}