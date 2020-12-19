using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OSRSGearRandomizer
{
    public partial class ItemDetailWindow : Window
    {
        public ItemDetailWindow(Item item, Window owner)
        {
            InitializeComponent();
            this.DataContext = item;
            this.Owner = owner;

            if (item == null)
                this.Close();

            if (item.Equipment != null)
            {
                if (item.Equipment.AttackStab >= 0) lblBonusAttStab.Content = "Stab +" + item.Equipment.AttackStab.ToString(); else lblBonusAttStab.Content = "Stab " + item.Equipment.AttackStab.ToString();
                if (item.Equipment.AttackSlash >= 0) lblBonusAttSlash.Content = "Slash +" + item.Equipment.AttackSlash.ToString(); else lblBonusAttSlash.Content = "Slash " + item.Equipment.AttackSlash.ToString();
                if (item.Equipment.AttackCrush >= 0) lblBonusAttCrush.Content = "Crush +" + item.Equipment.AttackCrush.ToString(); else lblBonusAttCrush.Content = "Crush " + item.Equipment.AttackCrush.ToString();
                if (item.Equipment.AttackRanged >= 0) lblBonusAttRanged.Content = "Range +" + item.Equipment.AttackRanged.ToString(); else lblBonusAttRanged.Content = "Range " + item.Equipment.AttackRanged.ToString();
                if (item.Equipment.AttackMagic >= 0) lblBonusAttMagic.Content = "Magic +" + item.Equipment.AttackMagic.ToString(); else lblBonusAttMagic.Content = "Magic " + item.Equipment.AttackMagic.ToString();
                if (item.Equipment.DefenceStab >= 0) lblBonusDefStab.Content = "Stab +" + item.Equipment.DefenceStab.ToString(); else lblBonusDefStab.Content = "Stab " + item.Equipment.DefenceStab.ToString();
                if (item.Equipment.DefenceSlash >= 0) lblBonusDefSlash.Content = "Slash +" + item.Equipment.DefenceSlash.ToString(); else lblBonusDefSlash.Content = "Slash " + item.Equipment.DefenceSlash.ToString();
                if (item.Equipment.DefenceCrush >= 0) lblBonusDefCrush.Content = "Crush +" + item.Equipment.DefenceCrush.ToString(); else lblBonusDefCrush.Content = "Crush " + item.Equipment.DefenceCrush.ToString();
                if (item.Equipment.DefenceRanged >= 0) lblBonusDefRanged.Content = "Range +" + item.Equipment.DefenceRanged.ToString(); else lblBonusDefRanged.Content = "Range " + item.Equipment.DefenceRanged.ToString();
                if (item.Equipment.DefenceMagic >= 0) lblBonusDefMagic.Content = "Magic +" + item.Equipment.DefenceMagic.ToString(); else lblBonusDefMagic.Content = "Magic " + item.Equipment.DefenceMagic.ToString();
                if (item.Equipment.MeleeStrength >= 0) lblBonusStrMelee.Content = "Melee strength +" + item.Equipment.MeleeStrength.ToString(); else lblBonusStrMelee.Content = "Melee strength " + item.Equipment.MeleeStrength.ToString();
                if (item.Equipment.RangedStrength >= 0) lblBonusStrRanged.Content = "Ranged strength +" + item.Equipment.RangedStrength.ToString(); else lblBonusStrRanged.Content = "Ranged strength " + item.Equipment.RangedStrength.ToString();
                if (item.Equipment.MagicDamage >= 0) lblBonusStrMagic.Content = "Magic damage +" + item.Equipment.MagicDamage.ToString() + "%"; else lblBonusStrMagic.Content = "Magic damage " + item.Equipment.MagicDamage.ToString() + "%";
                if (item.Equipment.Prayer >= 0) lblBonusPrayer.Content = "Prayer +" + item.Equipment.Prayer.ToString(); else lblBonusPrayer.Content = "Prayer " + item.Equipment.Prayer.ToString();
            }
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }
    }
}
