using UnityEngine;
using UnityEngine.EventSystems;

namespace HHG.Common
{
    public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        private UITooltip ui;

        private void Start()
        {
            ui = Locator.Get<UITooltip>();
        }

        private void OnMouseEnter()
        {
            ShowTooltip();
        }

        private void OnMouseExit()
        {
            HideTooltip();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            ShowTooltip();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            HideTooltip();
        }

        private void ShowTooltip()
        {
            if (ui && gameObject.TryGetComponent(out ITooltip tooltip))
            {
                ui.Show(tooltip);
            }
        }

        private void HideTooltip()
        {
            ui?.Hide();
        }
    } 
}