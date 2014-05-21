using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BlackJack
{
    public partial class BlackJack : Form
    {
        //Variables
        double accountsum = 100.00;
        double betamount = 0.00;
        int playersum = 0;
        int playercardsum1 = 0;
        int playercardsum2 = 0;
        int playercardsum3 = 0;
        int playercardsum4 = 0;
        int playercardsum5 = 0;
        int dealersum = 0;
        int dealercardsum1 = 0;
        int dealercardsum2 = 0;
        int dealercardsum3 = 0;
        int dealercardsum4 = 0;
        int dealercardsum5 = 0;
        
        int NumberOfClick = 0;

        Random rnd1 = new Random();
        int seednum = 1;

        public BlackJack()
        {
            InitializeComponent();
        }
        
        private int generatecard(PictureBox cardface)
        {
            seednum = rnd1.Next(1, 10000);
            Random rnd2 = new Random(seednum);
            int card = rnd2.Next(1, 14);
            int cardsum = 0;
            switch (card){
                case 1://SpadeA
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spadeA.jpg"; 
                    cardsum = 11;
                    return cardsum;
                case 2://Spade2
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spade2.jpg"; 
                    cardsum = 2;
                    return cardsum;
                case 3://Spade3
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spade3.jpg";
                    cardsum = 3;
                    return cardsum;
                case 4://Spade4
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spade4.jpg"; 
                    cardsum = 4;
                    return cardsum;
                case 5://Spade5
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spade5.jpg"; 
                    cardsum = 5;
                    return cardsum;
                case 6://Spade6
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spade6.jpg"; 
                    cardsum = 6;
                    return cardsum;
                case 7://Spade7
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spade7.jpg"; 
                    cardsum = 7;
                    return cardsum;
                case 8://Spade8
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spade8.jpg"; 
                    cardsum = 8;
                    return cardsum;
                case 9://Spade9
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spade9.jpg"; 
                    cardsum = 9;
                    return cardsum;
                case 10://Spade10
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spade10.jpg"; 
                    cardsum = 10;
                    return cardsum;
                case 11://SpadeJ
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spadeJ.jpg"; 
                    cardsum = 10;
                    return cardsum;
                case 12://SpadeQ
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spadeQ.jpg"; 
                    cardsum = 10;
                    return cardsum;
                case 13://SpadeK
                    cardface.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/spadeK.jpg"; 
                    cardsum = 10;
                    return cardsum;
                default:
                    
                    return cardsum;
            }
        }



        private void stand_Click(object sender, EventArgs e)
        {
            stand.Enabled = false;
            hit.Enabled = false;
            bet.Enabled = true;

            dealersum = dealercardsum1;
            dealercardsum2 = generatecard(dealercard2);
            if (dealersum > 10 && dealercardsum2 == 11)
            {
                dealercardsum2 = 1;
            }
            dealersum = dealercardsum1 + dealercardsum2;
            
            dealercount.Text = "" + dealersum;

            if (dealersum >= 17)
            {
                //nothing
            }
            else
            {

                if (dealersum < 17)
                {
                    dealercardsum3 = generatecard(dealercard3);
                    if (dealersum > 10 && dealercardsum3 == 11)
                    {
                        dealercardsum3 = 1;
                    }
                    dealersum += dealercardsum3;
                    dealercount.Text = "" + dealersum;
                }
                if (dealersum < 17)
                {
                    dealercardsum4 = generatecard(dealercard4);
                    if (dealersum > 10 && dealercardsum4 == 11)
                    {
                        dealercardsum4 = 1;
                    }
                    dealersum += dealercardsum4;
                    dealercount.Text = "" + dealersum;
                }
                if (dealersum < 17)
                {
                    dealercardsum5 = generatecard(dealercard5);
                    if (dealersum > 10 && dealercardsum5 == 11)
                    {
                        dealercardsum5 = 1;
                    }
                    dealersum += dealercardsum5;
                    dealercount.Text = "" + dealersum;
                }
            }
            //Checking for win
            double win = betamount * 2;
            if (dealersum > 21)
            {
                messagebox.Text = "You Won $" + win + "!";
                accountsum += win;
            }
            else if (playersum > dealersum)
            {
                messagebox.Text = "You Won $" +  win + "!";
                accountsum += win;
            }
            else if (playersum == dealersum)
            {
                messagebox.Text = "Push";
                accountsum += betamount;
            }
            else
            {
                messagebox.Text = "You lose!";
            }
            account.Text = "$" + accountsum;
            add.Enabled = true;
            subtract.Enabled = true;

        }

        private void BlackJack_Load(object sender, EventArgs e)
        {
            messagebox.Text = "Welcome to the BlackJack Table!!";
            account.Text = "$" + accountsum;
            betsum.Text = "$0";
            playercount.Text = "" + playersum;
            dealercount.Text = "" + dealersum;
            hit.Enabled = false;
            stand.Enabled = false;
            bet.BackColor = Color.Green;
            hit.BackColor = Color.Green;
            stand.BackColor = Color.Green;
            
        }


        private void add_Click(object sender, EventArgs e)
        {
            if (betamount < accountsum)
            {
                betamount += 1.00;
                bet.Enabled = true;
            }   
            betsum.Text = "$" + betamount;

        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (betamount > 0)
            {
                betamount -= 1.00;
                bet.Enabled = true;
            }
            betsum.Text = "$" + betamount;
        }
        private void reset()
        {
            messagebox.Text = "";

            playercard1.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/cardback.jpg";
            playercard2.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/cardback.jpg";
            playercard3.Image = null;
            playercard4.Image = null;
            playercard5.Image = null;
            dealercard1.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/cardback.jpg";
            dealercard2.ImageLocation = "https://raw.githubusercontent.com/KennyKYLam/BlackJack/master/BlackJack/BlackJack/images/cardback.jpg";
            dealercard3.Image = null;
            dealercard4.Image = null;
            dealercard5.Image = null;

            NumberOfClick = 0;
            playersum = 0;
            dealersum = 0;

        }

        private void bet_Click(object sender, EventArgs e) //play button
        {
            reset();
            bet.Enabled = false;
            //amountbetted.BringToFront();
            amountbetted.Text = "$" + betamount;

            if (betamount == 0)
            {
                messagebox.Text = "Please bet!";
                bet.Enabled = true;
            }
            else if (accountsum - betamount < 0)
            {
                messagebox.Text = "Not enough $$!";
            }
            else
            {
                stand.Enabled = true;
                hit.Enabled = true;
                add.Enabled = false;
                subtract.Enabled = false;

                accountsum = accountsum - betamount;
                account.Text = "$" + accountsum;

                playercardsum1 = generatecard(playercard1);
                playercardsum2 = generatecard(playercard2);

                dealercardsum1 = generatecard(dealercard1);

                playersum = playercardsum1; 
                if (playersum > 10 && playercardsum2 == 11)
                {
                    playercardsum2 = 1;
                }
                playersum = playercardsum1 + playercardsum2;
                playercount.Text = "" + playersum;

                if ((playercardsum1 == 10 && playercardsum2 == 11) || (playercardsum1 == 11 && playercardsum2 == 10))
                {
                    double win = betamount * 2.5;
                    messagebox.Text = "BLACKJACK! You Won $" + win + "!";
                    accountsum += win;
                    account.Text = "$" + accountsum;
                    hit.Enabled = false;
                    stand.Enabled = false;
                    bet.Enabled = true;
                    add.Enabled = true;
                    subtract.Enabled = true;
                }

                dealersum = dealercardsum1;
                dealercount.Text = "" + dealersum;
            }
        }

        private void hit_Click(object sender, EventArgs e)
        {
            ++NumberOfClick;
            switch (NumberOfClick)
            {
                case 1:
                    // this is the first click
                    playercardsum3 = generatecard(playercard3);
                    playersum += playercardsum3;
                    playercount.Text = "" + playersum;
                    break;
                case 2:
                    // this is the second click
                    playercardsum4 = generatecard(playercard4);
                    playersum += playercardsum4;
                    playercount.Text = "" + playersum;
                    break;
                case 3:
                    // this is the third click
                    playercardsum5 = generatecard(playercard5);
                    playersum += playercardsum5;
                    playercount.Text = "" + playersum;
                    break;
                default:
                    // other clicks
                    break;
            }

            if (playersum > 21) 
            {
                messagebox.Text = "BUSTED";
                hit.Enabled = false;
                stand.Enabled = false;
                bet.Enabled = true;
                add.Enabled = true;
                subtract.Enabled = true;
            }
        }


    }
}
