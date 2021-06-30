using Harion.Utility.Utils;
using Harion.Cooldown;
using SuperJesterRoles = TemplateHarion.SuperJester;

namespace TemplateHarion {

    [RegisterCooldownButton]
    public class Button : CustomButton<Button> {

        public override void OnCreateButton() {
            Timer = 30f;
            MaxTimer = 30f;
            UseNumber = 4;
            Roles = SuperJesterRoles.Instance;
            SetSprite("TemplateHarion.Resources.Example.png", 125);
            DecreamteUseNimber = UseNumberDecremantion.OnClick;
            Key = SuperJesterRoles.KeyBindExample.Key;
        }

        public override void OnClick() => VentUtils.PlaceVent(PlayerControl.LocalPlayer.transform.position);
    }
}