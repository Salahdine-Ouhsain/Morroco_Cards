using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace morroco_cartes
{
    public partial class Main_screen : Form
    {

        showAllCartes badil;
        

        ImageList Specifytype(byte type)
        {
            switch (type)
            {
                case 0:
                    {
                        return fls;

                    }
                case 1:
                    {
                        return jbn;
                    }
                case 2:
                    {
                        return sif;
                    }
                case 3:
                    {
                        return hrwt;
                    }
            }
       return sif;
            
        }

     /// ///////////////////////////////////////////////////////////////////////

      void gitvalutag(ref byte tp,ref byte num,string _tag)
        {
            char kk = _tag[0];
            string j = Convert.ToString(kk);
            tp = Convert.ToByte(j); ;

            kk = _tag[2];
            j = Convert.ToString(kk);
            num = Convert.ToByte(j);
        }

        void selectJokerOfAI(PictureBox pic)
        {
            Random rand= new Random();
            int tp = Convert.ToInt32(rand.Next(0,4));

            pic.Tag=(tp.ToString()+","+"6").ToString();


            switch (tp)
            {
                    case 0:
                    {
                        MessageBox.Show("The joker type is a penny", "The computer used the joker",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        break;
                    }
                    case 1:
                    {
                        MessageBox.Show("The joker type is a cheese", "The computer used the joker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("The joker type is a sword", "The computer used the joker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("The joker type is a truncheon", "The computer used the joker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

            }
        }

        void acsesforplayer(byte type, byte numCards,PictureBox imglist,bool istable=false)
        {

            if (istable)
            {
                gitvalutag(ref typecard,ref numcard,table.Tag.ToString());

                ARcartes[typecard, numcard] = 99;

                typecard = type;numcard = numCards;

                ARcartes[type, numCards] = 10;




            }
            else
            {
               ARcartes[typecard, numcard] = 1;
            }

           

            if (istable)
            {

                if (numcard == 6) {

                    if (turne == enturn.player) {

                        imglist.Tag = frmSelect_jocker_type.frjoker.fr2_joker();

                    }
                    else
                    {
                        selectJokerOfAI(imglist);
                    }

                }
                else if (numcard == 0)
                {
                    
                    
                        isnot0_0 = false;
                    imglist.Tag = (type + "," + numCards).ToString();

                }
                else
                {
                    imglist.Tag = (type + "," + numCards).ToString();
                }



            }
            else
            {
                imglist.Tag = (type + "," + numCards).ToString();
            }
            
            
                
            



            ImageList tp = Specifytype(type);

            imglist.Image = tp.Images[numCards];

            imglist.Visible = true;
            imglist.Refresh();


            badil = showAllCartes.fr2;
        }

        /// ///////////////////////////////////////////////////////////////////////////
             //1 card player
             // 2 card AI
             // 10 is table
             // 99 is used

        /// ///////////////////////////////////////////////////////////////////////////







        public static Main_screen fr1= new Main_screen();

        public Main_screen()
        {
            fr1 = this;
            showAllCartes.fr2 = new showAllCartes();
            
          
            InitializeComponent();

            
            
        }


        bool isnot0_0 = true;
        bool thismodeadd2 = false;

        byte  typecard = 0;
        byte numcard = 0;


     enum enturn {player=1,AI=2};
        enturn turne= enturn.player;

    byte[,] ARcartes ={ { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

        short countor = 0;

        void selectCsrd()
        {
            do
            {
                
                Random rando = new Random();
                typecard = Convert.ToByte( rando.Next(0, 4));
                numcard = Convert.ToByte(rando.Next(0, 10));

            } while (ARcartes[typecard,numcard]!=0);
            
        }
      void FirstDistributecards()
        {

            selectCsrd();
            acsesforplayer(typecard,numcard,player1);
            ARcartes[typecard, numcard] = 1;
            Thread.Sleep(500);

            selectCsrd();
            acsesforplayer(typecard, numcard,player2);
            ARcartes[typecard, numcard] = 1;
            Thread.Sleep(500);

            selectCsrd();
            acsesforplayer(typecard, numcard,player3);
            ARcartes[typecard, numcard] = 1;
            Thread.Sleep(500);

            selectCsrd();
            acsesforplayer(typecard, numcard,player4);
            ARcartes[typecard, numcard] = 1;
            Thread.Sleep(500);
            //____________________________________

            selectCsrd();
            ARcartes[typecard, numcard] = 2;
         

            selectCsrd();
            ARcartes[typecard, numcard] = 2;
           

            selectCsrd();
             ARcartes[typecard, numcard] = 2;
         

            selectCsrd();
            ARcartes[typecard, numcard] = 2;

        }

       void Announcingthewinner(enturn theturne)
        {


            if(theturne==enturn.player)
            {   
                MessageBox.Show("The winner is YOU ", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            else
            {
                MessageBox.Show("The winner is computer", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            lblRestartT_Click();

        }



        



        void checkPlayerCardsISfull()
        {

            if (player1.Tag.ToString() == ".")
            {
                acsesforplayer(typecard, numcard, player1);
            }
            else if(player2.Tag.ToString() == ".")
            {
                acsesforplayer(typecard, numcard, player2);
            }
            else if (player3.Tag.ToString() == ".")
            {
                acsesforplayer(typecard, numcard, player3);
            }
            else if (player4.Tag.ToString() == ".")
            {
                acsesforplayer(typecard, numcard, player4);



            }
            else if (showAllCartes.fr2.player5.Tag.ToString() == ".")
            {

                acsesforplayer(typecard, numcard, showAllCartes.fr2.player5);
            }
            else if (showAllCartes.fr2.player6.Tag.ToString() == ".")
            {

                acsesforplayer(typecard, numcard, showAllCartes.fr2.player6);
            }
            else if (showAllCartes.fr2.player7.Tag.ToString() == ".")
            {

                acsesforplayer(typecard, numcard, showAllCartes.fr2.player7);
            }
            else if (showAllCartes.fr2.player8.Tag.ToString() == ".")
            {

                acsesforplayer(typecard, numcard, showAllCartes.fr2.player8);
            }
            else if (showAllCartes.fr2.player9.Tag.ToString() == ".")
            {

                acsesforplayer(typecard, numcard, showAllCartes.fr2.player9);
            }
            else if (showAllCartes.fr2.player10.Tag.ToString() == ".")
            {

                acsesforplayer(typecard, numcard, showAllCartes.fr2.player10);
            }
            else if (showAllCartes.fr2.player11.Tag.ToString() == ".")
            {

                acsesforplayer(typecard, numcard, showAllCartes.fr2.player11);
            }
            else if (showAllCartes.fr2.player12.Tag.ToString() == ".")
            {

                acsesforplayer(typecard, numcard, showAllCartes.fr2.player12);
            }
            else if (showAllCartes.fr2.player13.Tag.ToString() == ".")
            {

                acsesforplayer(typecard, numcard, showAllCartes.fr2.player13);
            }
            else if (showAllCartes.fr2.player14.Tag.ToString() == ".")
            {

                acsesforplayer(typecard, numcard, showAllCartes.fr2.player14);
            }
            else if (showAllCartes.fr2.player15.Tag.ToString() == ".")
            {

                acsesforplayer(typecard, numcard, showAllCartes.fr2.player15);
            }
            else if (showAllCartes.fr2.player16.Tag.ToString() == ".")
            {

                acsesforplayer(typecard, numcard, showAllCartes.fr2.player16);
            }

        }
        void checkAICardsISfull()
        {
            if (AI1.Tag.ToString() == ".")
            {
                acsesforplayer(typecard, numcard, AI1);
            }
            else if (AI2.Tag.ToString() == ".")
            {
                acsesforplayer(typecard, numcard, AI2);
            }
            else if (AI3.Tag.ToString() == ".")
            {
                acsesforplayer(typecard, numcard, AI3);
            }
            else if (AI4.Tag.ToString() == ".")
            {
                acsesforplayer(typecard, numcard, AI4);
            }
            
        }

        void resetCarte99()
        {
            for (int i=0;i<4;i++)
            {
                for (int o = 0; o < 10; o++)
                {
                    if (ARcartes[i, o] == 99) { ARcartes[i, o] = 0; };
                }
            }
        }

        void resetCarteTo0()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int o = 0; o < 10; o++)
                {
                     ARcartes[i, o] = 0;
                }
            }
        }

        void Addcard()
        {

            countor++;

            if (countor>=15)
            {
                resetCarte99();
                countor = 0;
            }

            selectCsrd();

            if (turne == enturn.player)
            {
                ARcartes[typecard, numcard] = 1;

                checkPlayerCardsISfull();

                turne = enturn.AI;

                acsespointer();
                if (!thismodeadd2)
                {
                    playAI();
                }
                
            }
            else
            {
                ARcartes[typecard, numcard] = 2;

                turne = enturn.player;
                acsespointer();
            }
        }
        private void table_Click(object sender, EventArgs e)
        {
            
        }

        private void Distributecards()
        {
            

            table.Image = sif.Images[4];
            table.Tag = "2,4";
            ARcartes[2, 4] = 10;
            FirstDistributecards();
        }

        void playAI()
        {
            int AI_type = 0, AI_num = 0;

            bool Did_he_run_outo_fcards=true;

            Thread.Sleep(100);
            player1.Refresh(); player2.Refresh(); player3.Refresh(); player4.Refresh(); picpointerPlayer.Refresh(); picpionterAI.Refresh();


            for (short type = 0; type < 4; type++)
            {

                for (short num = 0; num < 10; num++)
                {

                    if (ARcartes[type, num] == 2) {

                        Did_he_run_outo_fcards = false;

                        if (numberOFcard(type + "," + num.ToString(), table.Tag.ToString(), ref AI_type, ref AI_num))
                        {

                            acsesforplayer(Convert.ToByte(AI_type), Convert.ToByte(AI_num), table, true);

                            if (numcard == 1)
                            {

                                if (turne == enturn.player)
                                {
                                    thismodeadd2 = true;

                                    turne = enturn.AI;
                                    Addcard();
                                    turne = enturn.AI;
                                    Addcard();

                                    thismodeadd2=false;
                                }
                                else
                                {
                                    thismodeadd2 = true;

                                    turne = enturn.player;
                                    Addcard();
                                    turne = enturn.player;
                                    Addcard();
                                     
                                    isnot0_0 = false;
                                    thismodeadd2 = false;
                                }

                            }

                            if (isnot0_0)
                            {

                                turne = enturn.player;
                                acsespointer();

                            }
                            else
                            {
                                isnot0_0 = true;

                                playAI();
                            }


                           
                            return;

                        }


                    } else if (type==3 && num==9)
                    {
                        if (Did_he_run_outo_fcards) {

                            Announcingthewinner(turne);

                        }
                        else
                        {
                            Addcard();
                        }
                    }
                }


            }

            Did_he_run_outo_fcards = true;

           
        }










        void Transfercards2(PictureBox pic)
        {

            if (player1.Tag.ToString() == "." || player1 == pic)
            {
                if (player1 == pic)
                {
                    return;
                }
                player1.Visible = pic.Visible;
                player1.Image = pic.Image; player1.Tag = pic.Tag;
                player1.Refresh();

                Emptythefield(pic);
            }
            else if (player2.Tag.ToString() == "." || player2 == pic)
            {
                if (player2 == pic)
                {
                    return;
                }
                player2.Visible = pic.Visible;
                player2.Image = pic.Image;player2.Tag = pic.Tag;
                player2 .Refresh();

                Emptythefield(pic);


            }
            else if (player3.Tag.ToString() == "." || player3 == pic)
            {
                if (player3 == pic)
                {
                    return;
                }
                player3.Visible = pic.Visible;
                player3.Image = pic.Image; player3.Tag = pic.Tag;
                player3 .Refresh();

                Emptythefield(pic);

            }
            else if (player4.Tag.ToString() == "." || player4 == pic)
            {
                if (player4 == pic)
                {
                    return;
                }
                player4.Visible = pic.Visible;
                player4.Image = pic.Image; player4.Tag = pic.Tag;
                player4 .Refresh();

                Emptythefield(pic);




            }
            else if (showAllCartes.fr2.player5.Tag.ToString() == "." || showAllCartes.fr2.player5 == pic)
            {
                if (showAllCartes.fr2.player5 == pic)
                {
                    return;
                }
                showAllCartes.fr2.player5.Visible = pic.Visible;
                showAllCartes.fr2.player5.Image = pic.Image; showAllCartes.fr2.player5.Tag = pic.Tag;
                Emptythefield(pic);





            }
            else if (showAllCartes.fr2.player6.Tag.ToString() == "." || showAllCartes.fr2.player6 == pic)
            {
                if (showAllCartes.fr2.player6 == pic)
                {
                    return;
                }
                showAllCartes.fr2.player6.Visible = pic.Visible;
                showAllCartes.fr2.player6.Image = pic.Image; showAllCartes.fr2.player6.Tag = pic.Tag;
                Emptythefield(pic);







            }
            else if (showAllCartes.fr2.player7.Tag.ToString() == "." || showAllCartes.fr2.player7 == pic)
            {
                if (showAllCartes.fr2.player7 == pic)
                {
                    return;
                }
                showAllCartes.fr2.player7.Visible = pic.Visible;
                showAllCartes.fr2.player7.Image = pic.Image; showAllCartes.fr2.player7.Tag = pic.Tag;
                Emptythefield(pic);





            }
            else if (showAllCartes.fr2.player8.Tag.ToString() == "." || showAllCartes.fr2.player8 == pic)
            {
                if (showAllCartes.fr2.player8 == pic)
                {
                    return;
                }
                showAllCartes.fr2.player8.Visible = pic.Visible;
                showAllCartes.fr2.player8.Image = pic.Image; showAllCartes.fr2.player8.Tag = pic.Tag;
                Emptythefield(pic);







            }
            else if (showAllCartes.fr2.player9.Tag.ToString() == "." || showAllCartes.fr2.player9 == pic)
            {
                if (showAllCartes.fr2.player9 == pic)
                {
                    return;
                }
                showAllCartes.fr2.player9.Visible = pic.Visible;
                showAllCartes.fr2.player9.Image = pic.Image; showAllCartes.fr2.player9.Tag = pic.Tag;
                Emptythefield(pic);





            }
            else if (showAllCartes.fr2.player10.Tag.ToString() == "." || showAllCartes.fr2.player10 == pic)
            {
                if (showAllCartes.fr2.player10 == pic)
                {
                    return;
                }
                showAllCartes.fr2.player10.Visible = pic.Visible;
                showAllCartes.fr2.player10.Image = pic.Image; showAllCartes.fr2.player10.Tag = pic.Tag;
                Emptythefield(pic);




            }
            else if (showAllCartes.fr2.player11.Tag.ToString() == "." || showAllCartes.fr2.player11 == pic)
            {
                if (showAllCartes.fr2.player11 == pic)
                {
                    return;
                }
                showAllCartes.fr2.player11.Visible = pic.Visible;
                showAllCartes.fr2.player11.Image = pic.Image; showAllCartes.fr2.player11.Tag = pic.Tag;
                Emptythefield(pic);



            }
            else if (showAllCartes.fr2.player12.Tag.ToString() == "." || showAllCartes.fr2.player12 == pic)
            {
                if (showAllCartes.fr2.player12 == pic)
                {
                    return;
                }
                showAllCartes.fr2.player12.Visible = pic.Visible;
                showAllCartes.fr2.player12.Image = pic.Image; showAllCartes.fr2.player12.Tag = pic.Tag;
                Emptythefield(pic);


            }
            else if (showAllCartes.fr2.player13.Tag.ToString() == "." || showAllCartes.fr2.player13 == pic)
            {
                if (showAllCartes.fr2.player13 == pic)
                {
                    return;
                }
                showAllCartes.fr2.player13.Visible = pic.Visible;
                showAllCartes.fr2.player13.Image = pic.Image; showAllCartes.fr2.player13.Tag = pic.Tag;
                Emptythefield(pic);
            }
           
            else if (showAllCartes.fr2.player14.Tag.ToString() == "." || showAllCartes.fr2.player14 == pic)
            {



                if (showAllCartes.fr2.player14 == pic)
                {
                    return;
                }
                showAllCartes.fr2.player14.Visible = pic.Visible;
                showAllCartes.fr2.player14.Image = pic.Image; showAllCartes.fr2.player14.Tag = pic.Tag;
                Emptythefield(pic);



            }
            else if (showAllCartes.fr2.player15.Tag.ToString() == "." || showAllCartes.fr2.player15 == pic)
            {


                if (showAllCartes.fr2.player15 == pic)
                {

                    
                    return;
                }
                showAllCartes.fr2.player15.Visible = pic.Visible;
                showAllCartes.fr2.player15.Image = pic.Image; showAllCartes.fr2.player15.Tag = pic.Tag;
                Emptythefield(pic);
            }

        }


        void Transfercards1()
        {

            if (showAllCartes.fr2.player16.Tag.ToString() != ".")
            {
                Transfercards2(showAllCartes.fr2.player16);
            }

             if (showAllCartes.fr2.player15.Tag.ToString()!= ".")
            {
                Transfercards2(showAllCartes.fr2.player15);
            } 
             

             if (showAllCartes.fr2.player14.Tag.ToString()!=  ".")
            {
                Transfercards2(showAllCartes.fr2.player14);
            }
             

             if (showAllCartes.fr2.player13.Tag.ToString()!=  ".")
            {
                Transfercards2(showAllCartes.fr2.player13);
            } 
             

             if (showAllCartes.fr2.player12.Tag.ToString()!= ".")
            {
                Transfercards2(showAllCartes.fr2.player12);
            } 
             

             if (showAllCartes.fr2.player11.Tag.ToString()!= ".")
            {
                Transfercards2(showAllCartes.fr2.player11);
            } 
             
             if (showAllCartes.fr2.player10.Tag.ToString()!= ".")
            {
                Transfercards2(showAllCartes.fr2.player10);
            }  
             

             if (showAllCartes.fr2.player9.Tag.ToString() != ".")
            {
                Transfercards2(showAllCartes.fr2.player9);
            } 
             

             if (showAllCartes.fr2.player8.Tag.ToString() != ".")
            {
                Transfercards2(showAllCartes.fr2.player8);
            } 
             

             if (showAllCartes.fr2.player7.Tag.ToString() != ".")
            {
                Transfercards2(showAllCartes.fr2.player7);
            }  
             
             if (showAllCartes.fr2.player6.Tag.ToString() != ".")
            {
                Transfercards2(showAllCartes.fr2.player6);
            } 
             

             if (showAllCartes.fr2.player5.Tag.ToString() != ".")
            {
                Transfercards2(showAllCartes.fr2.player5);
            }

             if (player4.Tag.ToString() != ".")
            {
                Transfercards2(player4);
            }


             if (player3.Tag.ToString() != ".")
            {
                Transfercards2(player3);
            }

             if (player2.Tag.ToString() != ".")
            {
                Transfercards2(player2);
            }

             if (player1.Tag.ToString() != ".")
            {
                Transfercards2(player1);
            }


        }








        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            showAllCartes showWallet = badil;

            showWallet.Show();
            

           //showCartes = new showAllCartes();
            //showCartes.Show();
        }

        private void socor_Click(object sender, EventArgs e)
        {
            Addcard();

        }

        public bool numberOFcard(string player_tag,string table_tag,ref int player_type,ref int player_hisNimber)
        {
            

            char kk = player_tag[0];
            string j = Convert.ToString(kk);
             player_type = Convert.ToByte(j); ;

             kk = player_tag[2];
             j=Convert.ToString(kk);  
             player_hisNimber = Convert.ToByte(j);

             kk = table_tag[0];
            j = Convert.ToString(kk);
            int table_type = Convert.ToByte(j); ;

             kk = table_tag[2];
            j = Convert.ToString(kk);
            int table_hisNimber = Convert.ToByte(j); ;

            return (player_type==table_type||player_hisNimber==table_hisNimber) ;

        }

        public void Emptythefield(PictureBox player)
        {                             
            player.Tag = ".";
            player.Image = null;
            player.Visible = false;

            player.Refresh();
            
        }

       public void playcard(PictureBox player){

            int player_type = 0;
            int player_hisNimber = 0;

         if (numberOFcard(player.Tag.ToString(), table.Tag.ToString() ,ref player_type,ref player_hisNimber) )
            {

                acsesforplayer(Convert.ToByte(player_type) , Convert.ToByte(player_hisNimber) , table,true);
                   Emptythefield(player);


                Transfercards1();

                if (player1.Tag.ToString() == ".")
                {
                    Announcingthewinner(turne);
                }


                else if (numcard == 1)
                {

                    if (turne == enturn.player)
                    {
                        thismodeadd2 = true;

                        turne = enturn.AI;
                        Addcard();
                        turne = enturn.AI;
                        Addcard();

                        isnot0_0 = false;
                        thismodeadd2 = false;
                    }
                    else
                    {
                        thismodeadd2 = true;

                        turne = enturn.player;
                        Addcard();
                        turne = enturn.player;
                        Addcard();

                        thismodeadd2 = false;
                    }


                }

                if (isnot0_0) { 

                     turne = enturn.AI;
                    playAI();
                }
                else
                {
                    isnot0_0 = true;
                }

               
            }
          else
            {
                MessageBox.Show("The card is invalid");
          }

       }
        

        public void player_Click(object sender, EventArgs e)
        {
            if (turne == enturn.player )
            {
                playcard((PictureBox)sender);

            }
            else
            {
                MessageBox.Show("this is not your turn");
            }
        }
        private void player2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void start()
        {
            Distributecards();
            acsespointer();

            lblStart.Visible = false;
            lblRestart.Visible = true;
            
        }

        void acsespointer()
        {
            if (turne== enturn.player)
            {
                picpionterAI.Visible = false;
                //picpointerPlayer.Visible = true;

                //picpionterAI.Refresh();
                //picpointerPlayer.Refresh();
            }
            else{
                picpionterAI.Visible = true;
                picpointerPlayer.Visible = false;

                picpionterAI.Refresh();
                picpointerPlayer.Refresh();
               
            }
        }
        private void lblRestartT_Click()
        {
            turne = enturn.player;
         



            resetCarteTo0();

            Emptythefield(showAllCartes.fr2.player5);
            Emptythefield(showAllCartes.fr2.player6);
            Emptythefield(showAllCartes.fr2.player7);
            Emptythefield(showAllCartes.fr2.player8);
            Emptythefield(showAllCartes.fr2.player9);
            Emptythefield(showAllCartes.fr2.player10);
            Emptythefield(showAllCartes.fr2.player11);
            Emptythefield(showAllCartes.fr2.player12);
            Emptythefield(showAllCartes.fr2.player13);
            Emptythefield(showAllCartes.fr2.player14);
            Emptythefield(showAllCartes.fr2.player15);
            Emptythefield(showAllCartes.fr2.player16);

            player1.Image = screns.Images[0];
            player2.Image = screns.Images[0];
            player3.Image = screns.Images[0];
            player4.Image = screns.Images[0];

            start();

        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            picbadil.Visible = true;
            start();
        }

        private void picpionterAI_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void AI1_Click(object sender, EventArgs e)
        {

        }

        private void AI2_Click(object sender, EventArgs e)
        {

        }

        private void AI3_Click(object sender, EventArgs e)
        {

        }

        private void AI4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void lblRestart_Click(object sender, EventArgs e)
        {
            lblRestartT_Click();
        }

        private void frmMainscreen_Load(object sender, EventArgs e)
        {

        }
    }
}
