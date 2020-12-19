using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace OSRSGearRandomizer
{
    public partial class MainWindow : Window
    {
        int rolls = 0;
        AppSettings settings;
        Bonuses bonuses;
        List<Item> equipmentList = new List<Item>();
        Item currentHelm;
        Item currentNeck;
        Item currentCape;
        Item currentAmmo;
        Item currentWeapon;
        Item currentChest;
        Item currentLegs;
        Item currentShield;
        Item currentGloves;
        Item currentBoots;
        Item currentRing;

        public MainWindow()
        {
            InitializeComponent();
            settings = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText(AppSettings.SettingsDataFilePath));
            equipmentList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(ItemData.ItemDataFilePath));
            if (equipmentList.Count == 0)
            {
                new DownloadingWindow().ShowDialog();
                equipmentList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(ItemData.ItemDataFilePath));
            }

            if (settings.HideRandomizeAll)
                BtnRandomizeAll.Visibility = Visibility.Hidden;
            else
                BtnRandomizeAll.Visibility = Visibility.Visible;
        }

        protected void BtnHelm_Click(object sender, RoutedEventArgs e)
        {
            List<Item> itemList = equipmentList.Where(r => r.Equipment.Slot == "head").ToList();
            itemList = ApplyFilters(itemList);
            if (itemList.Count <= 0)
                return;

            currentHelm = itemList[new Random().Next(itemList.Count())];
            ImageHelm.Source = currentHelm.Picture;
            ImageHelm.ToolTip = currentHelm.Name;
            UpdateGearStatistics();
            IncrementRoll();
        }

        private void BtnHelm_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentHelm != null) new ItemDetailWindow(currentHelm, this).ShowDialog();
        }

        protected void BtnNeck_Click(object sender, RoutedEventArgs e)
        {
            List<Item> itemList = equipmentList.Where(r => r.Equipment.Slot == "neck").ToList();
            itemList = ApplyFilters(itemList);
            if (itemList.Count <= 0)
                return;

            currentNeck = itemList[new Random().Next(itemList.Count())];
            ImageNeck.Source = currentNeck.Picture;
            ImageNeck.ToolTip = currentNeck.Name;
            UpdateGearStatistics();
            IncrementRoll();
        }

        private void BtnNeck_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentNeck != null) new ItemDetailWindow(currentNeck, this).ShowDialog();
        }

        protected void BtnAmmo_Click(object sender, RoutedEventArgs e)
        {
            List<Item> itemList = equipmentList.Where(r => r.Equipment.Slot == "ammo").ToList();
            itemList = ApplyFilters(itemList);
            if (itemList.Count <= 0)
                return;

            currentAmmo = itemList[new Random().Next(itemList.Count())];
            ImageAmmo.Source = currentAmmo.Picture;
            ImageAmmo.ToolTip = currentAmmo.Name;
            UpdateGearStatistics();
            IncrementRoll();
        }

        private void BtnAmmo_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentAmmo != null) new ItemDetailWindow(currentAmmo, this).ShowDialog();
        }

        protected void BtnCape_Click(object sender, RoutedEventArgs e)
        {
            List<Item> itemList = equipmentList.Where(r => r.Equipment.Slot == "cape").ToList();
            itemList = ApplyFilters(itemList);
            if (itemList.Count <= 0)
                return;

            currentCape = itemList[new Random().Next(itemList.Count())];
            ImageCape.Source = currentCape.Picture;
            ImageCape.ToolTip = currentCape.Name;
            UpdateGearStatistics();
            IncrementRoll();
        }

        private void BtnCape_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentCape != null) new ItemDetailWindow(currentCape, this).ShowDialog();
        }

        protected void BtnWeapon_Click(object sender, RoutedEventArgs e)
        {
            List<Item> itemList = equipmentList.Where(r => r.Equipment.Slot == "weapon").ToList();
            itemList = ApplyFilters(itemList);
            if (itemList.Count <= 0)
                return;

            currentWeapon = itemList[new Random().Next(itemList.Count())];
            ImageWeapon.Source = currentWeapon.Picture;
            ImageWeapon.ToolTip = currentWeapon.Name;
            UpdateGearStatistics();
            IncrementRoll();
        }

        private void BtnWeapon_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentWeapon != null) new ItemDetailWindow(currentWeapon, this).ShowDialog();
        }

        protected void BtnChest_Click(object sender, RoutedEventArgs e)
        {
            List<Item> itemList = equipmentList.Where(r => r.Equipment.Slot == "body").ToList();
            itemList = ApplyFilters(itemList);
            if (itemList.Count <= 0)
                return;

            currentChest = itemList[new Random().Next(itemList.Count())];
            ImageChest.Source = currentChest.Picture;
            ImageChest.ToolTip = currentChest.Name;
            UpdateGearStatistics();
            IncrementRoll();
        }

        private void BtnChest_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentChest != null) new ItemDetailWindow(currentChest, this).ShowDialog();
        }

        protected void BtnShield_Click(object sender, RoutedEventArgs e)
        {
            List<Item> itemList = equipmentList.Where(r => r.Equipment.Slot == "shield").ToList();
            itemList = ApplyFilters(itemList);
            if (itemList.Count <= 0)
                return;

            currentShield = itemList[new Random().Next(itemList.Count())];
            ImageShield.Source = currentShield.Picture;
            ImageShield.ToolTip = currentShield.Name;
            UpdateGearStatistics();
            IncrementRoll();
        }

        private void BtnShield_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentShield != null) new ItemDetailWindow(currentShield, this).ShowDialog();
        }

        protected void BtnLegs_Click(object sender, RoutedEventArgs e)
        {
            List<Item> itemList = equipmentList.Where(r => r.Equipment.Slot == "legs").ToList();
            itemList = ApplyFilters(itemList);
            if (itemList.Count <= 0)
                return;

            currentLegs = itemList[new Random().Next(itemList.Count())];
            ImageLegs.Source = currentLegs.Picture;
            ImageLegs.ToolTip = currentLegs.Name;
            UpdateGearStatistics();
            IncrementRoll();
        }

        private void BtnLegs_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentLegs != null) new ItemDetailWindow(currentLegs, this).ShowDialog();
        }

        protected void BtnGloves_Click(object sender, RoutedEventArgs e)
        {
            List<Item> itemList = equipmentList.Where(r => r.Equipment.Slot == "hands").ToList();
            itemList = ApplyFilters(itemList);
            if (itemList.Count <= 0)
                return;

            currentGloves = itemList[new Random().Next(itemList.Count())];
            ImageGloves.Source = currentGloves.Picture;
            ImageGloves.ToolTip = currentGloves.Name;
            UpdateGearStatistics();
            IncrementRoll();
        }

        private void BtnGloves_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentGloves != null) new ItemDetailWindow(currentGloves, this).ShowDialog();
        }

        protected void BtnBoots_Click(object sender, RoutedEventArgs e)
        {
            List<Item> itemList = equipmentList.Where(r => r.Equipment.Slot == "feet").ToList();
            itemList = ApplyFilters(itemList);
            if (itemList.Count <= 0)
                return;

            currentBoots = itemList[new Random().Next(itemList.Count())];
            ImageBoots.Source = currentBoots.Picture;
            ImageBoots.ToolTip = currentBoots.Name;
            UpdateGearStatistics();
            IncrementRoll();
        }

        private void BtnBoots_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentBoots != null) new ItemDetailWindow(currentBoots, this).ShowDialog();
        }

        protected void BtnRing_Click(object sender, RoutedEventArgs e)
        {
            List<Item> itemList = equipmentList.Where(r => r.Equipment.Slot == "ring").ToList();
            itemList = ApplyFilters(itemList);
            if (itemList.Count <= 0)
                return;
            
            currentRing = itemList[new Random().Next(itemList.Count())];
            ImageRing.Source = currentRing.Picture;
            ImageRing.ToolTip = currentRing.Name;
            UpdateGearStatistics();
            IncrementRoll();
        }

        private void BtnRing_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (currentRing != null) new ItemDetailWindow(currentRing, this).ShowDialog();
        }

        private List<Item> ApplyFilters(List<Item> items)
        {
            items = items.Where(i => i.Equipable == true && i.EquipableByPlayer == true && i.Duplicate == false).ToList();
            if (!settings.Untradeables) items = items.Where(i => i.Tradeable == true).ToList();
            if (!settings.QuestItems) items = items.Where(i => i.QuestItem == false).ToList();
            if (!settings.Members) items = items.Where(i => i.Members == false).ToList();
            if (settings.RequireStats)
            {
                List<Item> filteredItems = new List<Item>();
                foreach (Item item in items)
                {
                    int totalStats = 0;
                    totalStats += item.Equipment.AttackCrush;
                    totalStats += item.Equipment.AttackSlash;
                    totalStats += item.Equipment.AttackStab;
                    totalStats += item.Equipment.AttackMagic;
                    totalStats += item.Equipment.AttackRanged;
                    totalStats += item.Equipment.DefenceCrush;
                    totalStats += item.Equipment.DefenceSlash;
                    totalStats += item.Equipment.DefenceStab;
                    totalStats += item.Equipment.DefenceMagic;
                    totalStats += item.Equipment.DefenceRanged;
                    totalStats += item.Equipment.MeleeStrength;
                    totalStats += item.Equipment.MagicDamage;
                    totalStats += item.Equipment.RangedStrength;
                    totalStats += item.Equipment.Prayer;
                    if (totalStats > 0) filteredItems.Add(item);
                }
                items = filteredItems;
            }

            if (settings.CheckRequirements)
            {
                List<Item> filteredItems = new List<Item>();
                foreach (Item item in items)
                {
                    if (item.Equipment.Requirements != null)
                    {
                        bool valid = true;
                        if (valid) if (item.Equipment.Requirements.Attack > settings.Player.Skills.Attack) valid = false;
                        if (valid) if (item.Equipment.Requirements.Strength > settings.Player.Skills.Strength) valid = false;
                        if (valid) if (item.Equipment.Requirements.Defence > settings.Player.Skills.Defence) valid = false;
                        if (valid) if (item.Equipment.Requirements.Ranged > settings.Player.Skills.Ranged) valid = false;
                        if (valid) if (item.Equipment.Requirements.Prayer > settings.Player.Skills.Prayer) valid = false;
                        if (valid) if (item.Equipment.Requirements.Magic > settings.Player.Skills.Magic) valid = false;
                        if (valid) if (item.Equipment.Requirements.Runecraft > settings.Player.Skills.Runecraft) valid = false;
                        if (valid) if (item.Equipment.Requirements.Construction > settings.Player.Skills.Construction) valid = false;
                        if (valid) if (item.Equipment.Requirements.Hitpoints > settings.Player.Skills.Hitpoints) valid = false;
                        if (valid) if (item.Equipment.Requirements.Agility > settings.Player.Skills.Agility) valid = false;
                        if (valid) if (item.Equipment.Requirements.Herblore > settings.Player.Skills.Herblore) valid = false;
                        if (valid) if (item.Equipment.Requirements.Thieving > settings.Player.Skills.Thieving) valid = false;
                        if (valid) if (item.Equipment.Requirements.Crafting > settings.Player.Skills.Crafting) valid = false;
                        if (valid) if (item.Equipment.Requirements.Fletching > settings.Player.Skills.Fletching) valid = false;
                        if (valid) if (item.Equipment.Requirements.Slayer > settings.Player.Skills.Slayer) valid = false;
                        if (valid) if (item.Equipment.Requirements.Hunter > settings.Player.Skills.Hunter) valid = false;
                        if (valid) if (item.Equipment.Requirements.Mining > settings.Player.Skills.Mining) valid = false;
                        if (valid) if (item.Equipment.Requirements.Smithing > settings.Player.Skills.Smithing) valid = false;
                        if (valid) if (item.Equipment.Requirements.Fishing > settings.Player.Skills.Fishing) valid = false;
                        if (valid) if (item.Equipment.Requirements.Cooking > settings.Player.Skills.Cooking) valid = false;
                        if (valid) if (item.Equipment.Requirements.Firemaking > settings.Player.Skills.Firemaking) valid = false;
                        if (valid) if (item.Equipment.Requirements.Woodcutting > settings.Player.Skills.Woodcutting) valid = false;
                        if (valid) if (item.Equipment.Requirements.Farming > settings.Player.Skills.Farming) valid = false;
                        if (valid) filteredItems.Add(item);
                    }
                    else
                        filteredItems.Add(item);
                }
                items = filteredItems;
            }
            return items;
        }

        private void UpdateGearStatistics()
        {
            bonuses = new Bonuses();
            List<Item> items = new List<Item> {
                currentAmmo,
                currentBoots,
                currentCape,
                currentChest,
                currentGloves,
                currentHelm,
                currentLegs,
                currentNeck,
                currentRing,
                currentShield,
                currentWeapon,
            };

            foreach(Item item in items)
            {
                if (item != null)
                {
                    if (item.Equipment != null)
                    {
                        bonuses.AttackStab += item.Equipment.AttackStab;
                        bonuses.AttackSlash += item.Equipment.AttackSlash;
                        bonuses.AttackCrush += item.Equipment.AttackCrush;
                        bonuses.AttackRanged += item.Equipment.AttackRanged;
                        bonuses.AttackMagic += item.Equipment.AttackMagic;
                        bonuses.DefenceStab += item.Equipment.DefenceStab;
                        bonuses.DefenceSlash += item.Equipment.DefenceSlash;
                        bonuses.DefenceCrush += item.Equipment.DefenceCrush;
                        bonuses.DefenceRanged += item.Equipment.DefenceRanged;
                        bonuses.DefenceMagic += item.Equipment.DefenceMagic;
                        bonuses.StrengthMelee += item.Equipment.MeleeStrength;
                        bonuses.StrengthRanged += item.Equipment.RangedStrength;
                        bonuses.StrengthMagic += item.Equipment.MagicDamage;
                        bonuses.Prayer += item.Equipment.Prayer;
                    }
                }
            }

            if (bonuses.AttackStab >= 0) lblBonusAttStab.Content = "Stab +" + bonuses.AttackStab.ToString(); else lblBonusAttStab.Content = "Stab " + bonuses.AttackStab.ToString();
            if (bonuses.AttackSlash >= 0) lblBonusAttSlash.Content = "Slash +" + bonuses.AttackSlash.ToString(); else lblBonusAttSlash.Content = "Slash " + bonuses.AttackSlash.ToString();
            if (bonuses.AttackCrush >= 0) lblBonusAttCrush.Content = "Crush +" + bonuses.AttackCrush.ToString(); else lblBonusAttCrush.Content = "Crush " + bonuses.AttackCrush.ToString();
            if (bonuses.AttackRanged >= 0) lblBonusAttRanged.Content = "Range +" + bonuses.AttackRanged.ToString(); else lblBonusAttRanged.Content = "Range " + bonuses.AttackRanged.ToString();
            if (bonuses.AttackMagic >= 0) lblBonusAttMagic.Content = "Magic +" + bonuses.AttackMagic.ToString(); else lblBonusAttMagic.Content = "Magic " + bonuses.AttackMagic.ToString();
            if (bonuses.DefenceStab >= 0) lblBonusDefStab.Content = "Stab +" + bonuses.DefenceStab.ToString(); else lblBonusDefStab.Content = "Stab " + bonuses.DefenceStab.ToString();
            if (bonuses.DefenceSlash >= 0) lblBonusDefSlash.Content = "Slash +" + bonuses.DefenceSlash.ToString(); else lblBonusDefSlash.Content = "Slash " + bonuses.DefenceSlash.ToString();
            if (bonuses.DefenceCrush >= 0) lblBonusDefCrush.Content = "Crush +" + bonuses.DefenceCrush.ToString(); else lblBonusDefCrush.Content = "Crush " + bonuses.DefenceCrush.ToString();
            if (bonuses.DefenceRanged >= 0) lblBonusDefRanged.Content = "Range +" + bonuses.DefenceRanged.ToString(); else lblBonusDefRanged.Content = "Range " + bonuses.DefenceRanged.ToString();
            if (bonuses.DefenceMagic >= 0) lblBonusDefMagic.Content = "Magic +" + bonuses.DefenceMagic.ToString(); else lblBonusDefMagic.Content = "Magic " + bonuses.DefenceMagic.ToString();
            if (bonuses.StrengthMelee >= 0) lblBonusStrMelee.Content = "Melee strength +" + bonuses.StrengthMelee.ToString(); else lblBonusStrMelee.Content = "Melee strength " + bonuses.StrengthMelee.ToString();
            if (bonuses.StrengthRanged >= 0) lblBonusStrRanged.Content = "Ranged strength +" + bonuses.StrengthRanged.ToString(); else lblBonusStrRanged.Content = "Ranged strength " + bonuses.StrengthRanged.ToString();
            if (bonuses.StrengthMagic >= 0) lblBonusStrMagic.Content = "Magic damage +" + bonuses.StrengthMagic.ToString() + "%"; else lblBonusStrMagic.Content = "Magic damage " + bonuses.StrengthMagic.ToString() + "%";
            if (bonuses.Prayer >= 0) lblBonusPrayer.Content = "Prayer +" + bonuses.Prayer.ToString(); else lblBonusPrayer.Content = "Prayer " + bonuses.Prayer.ToString();
        }

        private string ConvertProperty(dynamic value)
        {
            if (value == null)
                return "";

            try
            {
                return Convert.ToString(value);
            } catch
            {
                return "";
            }
        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            new SettingsSkillsWindow().ShowDialog();
            settings = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText(AppSettings.SettingsDataFilePath));
            equipmentList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(ItemData.ItemDataFilePath));
            if (settings.HideRandomizeAll)
                BtnRandomizeAll.Visibility = Visibility.Hidden;
            else
                BtnRandomizeAll.Visibility = Visibility.Visible;
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void IncrementRoll(int by = 1)
        {
            if (BtnReset.Visibility == Visibility.Hidden)
                BtnReset.Visibility = Visibility.Visible;

            rolls += by;
            SetRollUI();
        }

        private void SetRollUI()
        {
            lblRolls.Content = "Rolls:  " + rolls.ToString();
        }

        private void Reset()
        {
            currentAmmo = null;
            currentBoots = null;
            currentCape = null;
            currentChest = null;
            currentGloves = null;
            currentHelm = null;
            currentLegs = null;
            currentNeck = null;
            currentRing = null;
            currentShield = null;
            currentWeapon = null;
            ImageAmmo.Source = new BitmapImage(new Uri("Resources/Images/ammo_slot.png", UriKind.Relative));
            ImageBoots.Source = new BitmapImage(new Uri("Resources/Images/boots_slot.png", UriKind.Relative));
            ImageCape.Source = new BitmapImage(new Uri("Resources/Images/cape_slot.png", UriKind.Relative));
            ImageChest.Source = new BitmapImage(new Uri("Resources/Images/chest_slot.png", UriKind.Relative));
            ImageGloves.Source = new BitmapImage(new Uri("Resources/Images/gloves_slot.png", UriKind.Relative));
            ImageHelm.Source = new BitmapImage(new Uri("Resources/Images/head_slot.png", UriKind.Relative));
            ImageLegs.Source = new BitmapImage(new Uri("Resources/Images/legs_slot.png", UriKind.Relative));
            ImageNeck.Source = new BitmapImage(new Uri("Resources/Images/neck_slot.png", UriKind.Relative));
            ImageRing.Source = new BitmapImage(new Uri("Resources/Images/ring_slot.png", UriKind.Relative));
            ImageShield.Source = new BitmapImage(new Uri("Resources/Images/shield_slot.png", UriKind.Relative));
            ImageWeapon.Source = new BitmapImage(new Uri("Resources/Images/weapon_slot.png", UriKind.Relative));
            BtnReset.Visibility = Visibility.Hidden;
            rolls = 0;
            SetRollUI();
        }

        private void BtnRandomizeAll_Click(object sender, RoutedEventArgs e)
        {
            BtnAmmo_Click(null, null);
            BtnBoots_Click(null, null);
            BtnCape_Click(null, null);
            BtnChest_Click(null, null);
            BtnGloves_Click(null, null);
            BtnHelm_Click(null, null);
            BtnLegs_Click(null, null);
            BtnNeck_Click(null, null);
            BtnRing_Click(null, null);
            BtnShield_Click(null, null);
            BtnWeapon_Click(null, null);
        }
    }
}
