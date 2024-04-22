using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        private string state;
        ArrayList Player_Items = new ArrayList();
        Weapon Sword = new Weapon(10, 200, 30);
        Item torch = new Item(1, 30);
        Warrior Player;
        Weapon Fangs1 = new Weapon(1, 10, 20);
        ArrayList Creature1_items = new ArrayList();
        Creature Creature1;
        Weapon Fangs2 = new Weapon(1, 8, 15);
        ArrayList Creature2_items = new ArrayList();
        Creature Creature2;
        HealPotion potion = new HealPotion(30, 1, 30);
        bool can_attack;
        bool[] inventory = new bool[6];
        Creature Trader = new Creature(20, 1000, 1000, 1000, new ArrayList());
        public Form1()
        {
            InitializeComponent();
            TraderInteface.Visible = false;

            Player_Items.Add(Sword);
            Player_Items.Add(torch);
            Player_Items.Add(potion);
            inventory[0] = true;
            inventory[1] = true;
            inventory[2] = true;
            Player = new Warrior(20, 400, 300, 600, Player_Items, 10);
            PlayerHealthBar.Text = "\n " + Player.hp_bar.ToString() + "/" + Player.max_hp;
            PlayerLevel.Text = "Level: " + Player.level.ToString();
            PlayerAttack.Text = "Dmg: " + ((Weapon)Player_Items[0]).damage.ToString();
            PlayerGold.Text = "Gold: " + Player.gold;
            can_attack = true;

            Creature1_items.Add(Fangs1);
            Creature1 = new Creature(5, 50, 0, 0, Creature1_items);
            NPC1HealthBar.Text = "\n" + Creature1.hp_bar.ToString() + "/" + Creature1.max_hp;
            NPC1Level.Text = "Level: " + Creature1.level.ToString();
            NPC1Attack.Text = "Dmg: " + ((Weapon)Creature1_items[0]).damage.ToString();

            Creature2_items.Add(Fangs2);
            Creature2 = new Creature(6, 70, 0, 0, Creature2_items);
            NPC2HealthBar.Text = "\n" + Creature2.hp_bar.ToString() + "/" + Creature2.max_hp;
            NPC2Level.Text = "Level: " + Creature2.level.ToString();
            NPC2Attack.Text = "Dmg: " + ((Weapon)Creature2_items[0]).damage.ToString();


        }

        private void NPC2Picture_Click(object sender, EventArgs e)
        {
            if ((state == "Attack")&&can_attack)
            {

                var temp = Creature2.hp_bar;
                Player.Hit(Creature2, Sword);
                DialogWindow.Text = "Log:\nYou did " + (temp - Creature2.hp_bar) + " dmg to creature.";
                NPC2HealthBar.Text = "\n" + Creature2.hp_bar.ToString() + "/" + Creature2.max_hp;
                NPC2Level.Text = "Level: " + Creature2.level.ToString();
                NPC2Attack.Text = "Dmg: " + ((Weapon)Creature2_items[0]).damage.ToString();
                if (Creature2.hp_bar < 0)
                {
                    NPC2Interface.Visible = false;
                    DialogWindow.Text += "\nThis attack was lethal for Wolf. You got levelup!";
                    Player.level++;
                }
                else
                    NPC2HP.Value = (int)((double)(Creature2.hp_bar) / (double)(Creature2.max_hp) * 100);

                PlayerHealthBar.Text = "\n " + Player.hp_bar.ToString() + "/" + Player.max_hp;
                PlayerLevel.Text = "Level: " + Player.level.ToString();
                PlayerAttack.Text = "Dmg: " + ((Weapon)Player_Items[0]).damage.ToString();
                PlayerGold.Text = "Gold: " + Player.gold;
                can_attack = false;
                state = "";
            }
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            state = "Attack";
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            can_attack = true;
            DialogWindow.Text = "";
            if (!(NPC2Interface.Visible) && !(NPC1Interface.Visible))
            {
                DialogWindow.Text = "\nAfter the fight was over, a stranger approached you. He turned out to be a potions dealer.";
                TraderInteface.Visible = true;
                TraderHealth.Text = "Health: " + Trader.max_hp;
                TraderAttack.Text = "Dmg: 100";
                TraderGold.Text = "Gold: " + Trader.gold;

            }

            if (NPC1Interface.Visible)
            {
                var temp = Player.hp_bar;
                Creature1.Hit(Player, Fangs1);
                DialogWindow.Text = "\nCreature1 did " + (temp - Player.hp_bar) + " dmg to you.";
                if (Player.hp_bar > 0)
                {
                    PlayerHealthBar.Text = "\n " + Player.hp_bar.ToString() + "/" + Player.max_hp;
                    PlayerHealth.Value = (int)((double)(Player.hp_bar) / (double)(Player.max_hp) * 100);
                }
                else
                {
                    PlayerHealthBar.Text = "\n " + Player.hp_bar.ToString() + "/" + Player.max_hp;
                    DialogWindow.Text += "\nIt was lethal. You died.";
                    MessageBox.Show("You lose");
                }
            }
            if ((Player.hp_bar > 0) && (NPC2Interface.Visible))
            {
                var temp = Player.hp_bar;
                Creature2.Hit(Player, Fangs2);
                DialogWindow.Text += "\nCreature2 did " + (temp - Player.hp_bar) + " dmg to you.";
                if (Player.hp_bar > 0)
                {
                    PlayerHealthBar.Text = "\n " + Player.hp_bar.ToString() + "/" + Player.max_hp;
                    PlayerHealth.Value = (int)((double)(Player.hp_bar) / (double)(Player.max_hp) * 100);
                }
                else
                {
                    PlayerHealthBar.Text = "\n " + Player.hp_bar.ToString() + "/" + Player.max_hp;
                    DialogWindow.Text += "\nIt was lethal. You died.";
                    MessageBox.Show("You lose");
                }
            }
        }
        

        private void NPC1Picture_Click(object sender, EventArgs e)
        {
            if ((state == "Attack") && can_attack)
            {

                var temp = Creature1.hp_bar;
                Player.Hit(Creature1, Sword);
                DialogWindow.Text = "Log:\nYou did " + (temp - Creature1.hp_bar) + " dmg to creature.";
                NPC1HealthBar.Text = "\n" + Creature1.hp_bar.ToString() + "/" + Creature1.max_hp;
                NPC1Level.Text = "Level: " + Creature1.level.ToString();
                NPC1Attack.Text = "Dmg: " + ((Weapon)Creature2_items[0]).damage.ToString();
                if (Creature1.hp_bar < 0)
                {
                    NPC1Interface.Visible = false;
                    DialogWindow.Text += "\nThis attack was lethal for Wolf. You got levelup!";
                    Player.level++;
                    PlayerLevel.Text = "Level: " + Player.level.ToString();
                    PlayerAttack.Text = "Dmg: " + ((Weapon)Player_Items[0]).damage.ToString();
                    PlayerGold.Text = "Gold: " + Player.gold;
                }
                else
                    NPC1HP.Value = (int)((double)(Creature1.hp_bar) / (double)(Creature1.max_hp) * 100);
                can_attack = false;
                state = "";
            }
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            state = "Use";
        }

        private void Inventory3_Click(object sender, EventArgs e)
        {
            if (state == "Use")
            {
                Player.Heal(Player, potion);
                if (Player.hp_bar > Player.max_hp)
                    Player.hp_bar = Player.max_hp;
                PlayerHealthBar.Text = "\n " + Player.hp_bar.ToString() + "/" + Player.max_hp;
                PlayerHealth.Value = (int)((double)(Player.hp_bar) / (double)(Player.max_hp) * 100);
                inventory[2] = false;
                Inventory3.BackgroundImage = ConsoleApp1.Properties.Resources.Empty;
            }
        }

        private void TraderBuy_Click(object sender, EventArgs e)
        {
            state = "Buy";
        }

        private void TradeSlot1_Click(object sender, EventArgs e)
        {
            if (state == "Buy")
                if (Player.gold > potion.GetPrice())
                {
                    inventory[2] = true;
                    TradeSlot1.Image = ConsoleApp1.Properties.Resources.Empty;
                    Inventory3.BackgroundImage = ConsoleApp1.Properties.Resources.potion;
                    Player.Take(potion, Trader);
                    TraderGold.Text = "Gold: " + Trader.gold;
                    PlayerGold.Text = "Gold: " + Player.gold;
                }
        }

        private void TraderSell_Click(object sender, EventArgs e)
        {
            state = "Sell";
        }

        private void Inventory2_Click(object sender, EventArgs e)
        {
            if (state == "Sell")
            {
                if (Trader.gold > torch.GetPrice())
                {
                    Player_Items.Remove(1);
                    inventory[1] = false;
                    Inventory2.BackgroundImage = ConsoleApp1.Properties.Resources.Empty;
                    TradeSlot2.Image = ConsoleApp1.Properties.Resources.torch;
                    Player.Give(torch, Trader);
                    TraderGold.Text = "Gold: " + Trader.gold;
                    PlayerGold.Text = "Gold: " + Player.gold;
                }
            }
        }

        private void StealButton_Click(object sender, EventArgs e)
        {
            state = "Steal";
        }

        private void TraderPicture_Click(object sender, EventArgs e)
        {
            if (state == "Steal")
            {
                Random rnd = new Random();
                if (rnd.Next(0, 100) < 40)
                {
                    int temp = Player.gold;
                    Player.Take(Trader);
                    DialogWindow.Text = "Log:\nYou stole " + (Player.gold - temp) + " from trader.";
                    TraderGold.Text = "Gold: " + Trader.gold;
                    PlayerGold.Text = "Gold: " + Player.gold;
                }
                else
                {
                    DialogWindow.Text = "Log:\nYou attemp to steal money was spotted so trader left.";
                    TraderInteface.Visible = false;
                }
            }
        }
    }
}
