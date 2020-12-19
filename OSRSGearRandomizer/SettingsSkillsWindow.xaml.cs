using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace OSRSGearRandomizer
{
    public partial class SettingsSkillsWindow : Window
    {
        private static readonly Regex _regex = new Regex("[^0-9]+");
        private readonly AppSettings settings;
        public SettingsSkillsWindow()
        {
            InitializeComponent();
            settings = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText(AppSettings.SettingsDataFilePath));
            this.DataContext = settings;
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            e.Handled = _regex.IsMatch(e.Text);
            if (!e.Handled) {
                string input = tb.Text + e.Text;
                if (string.IsNullOrEmpty(input))
                    tb.Text = "1";
                else
                {
                    if (!int.TryParse(input, out int value))
                        e.Handled = true;
                    if (value > 99 || value < 1)
                        e.Handled = true;
                }
            }
        }

        private void TxtSkillAttack_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Attack = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillStrength_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Strength = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillDefence_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Defence = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillRanged_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Ranged = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillPrayer_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Prayer = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillMagic_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Magic = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillRunecraft_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Runecraft = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillConstruction_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Construction = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillHitpoints_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Hitpoints = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillAgility_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Agility = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillHerblore_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Herblore = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillThieving_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Thieving = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillCrafting_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Crafting = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillFletching_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Fletching = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillSlayer_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Slayer = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillHunter_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Hunter = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillMining_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Mining = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillSmithing_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Smithing = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillFishing_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Fishing = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillCooking_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Cooking = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillFiremaking_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Firemaking = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillWoodcutting_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Woodcutting = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtSkillFarming_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TxtBoxValidate(tb);
            settings.Player.Skills.Farming = int.Parse(tb.Text);
            settings.Save();
        }

        private void TxtBoxValidate(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
                textBox.Text = "1";
        }

        private void ChkMembers_Checked(object sender, RoutedEventArgs e)
        {
            settings.Members = true;
            settings.Save();
        }

        private void ChkCosmetics_Checked(object sender, RoutedEventArgs e)
        {
            settings.Cosmetics = true;
            settings.Save();
        }

        private void ChkQuestItems_Checked(object sender, RoutedEventArgs e)
        {
            settings.QuestItems = true;
            settings.Save();
        }

        private void ChkUntradeables_Checked(object sender, RoutedEventArgs e)
        {
            settings.Untradeables = true;
            settings.Save();
        }

        private void ChkRequireStats_Checked(object sender, RoutedEventArgs e)
        {
            settings.RequireStats = true;
            settings.Save();
        }

        private void ChkHideRandomizeAll_Checked(object sender, RoutedEventArgs e)
        {
            settings.HideRandomizeAll = true;
            settings.Save();
        }

        private void ChkRequirements_Checked(object sender, RoutedEventArgs e)
        {
            settings.CheckRequirements = true;
            settings.Save();
        }

        private void ChkMembers_Unchecked(object sender, RoutedEventArgs e)
        {
            settings.Members = false;
            settings.Save();
        }

        private void ChkCosmetics_Unchecked(object sender, RoutedEventArgs e)
        {
            settings.Cosmetics = false;
            settings.Save();
        }

        private void ChkQuestItems_Unchecked(object sender, RoutedEventArgs e)
        {
            settings.QuestItems = false;
            settings.Save();
        }

        private void ChkUntradeables_Unchecked(object sender, RoutedEventArgs e)
        {
            settings.Untradeables = false;
            settings.Save();
        }

        private void ChkRequireStats_Unchecked(object sender, RoutedEventArgs e)
        {
            settings.RequireStats = false;
            settings.Save();
        }
        private void ChkHideRandomizeAll_Unchecked(object sender, RoutedEventArgs e)
        {
            settings.HideRandomizeAll = false;
            settings.Save();
        }

        private void ChkRequirements_Unchecked(object sender, RoutedEventArgs e)
        {
            settings.CheckRequirements = false;
            settings.Save();
        }

        private void BtnUpdateItems_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Download Equipment Database?", "Confirm Download", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                new DownloadingWindow().ShowDialog();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }
    }
}
