using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class FrmJogoDaVelha : Form
    {

        //Stream xPr = this.GetType().Assembly.GetManifestResourceStream("JogoDaVelha.Resources.Inverno.jpg");
        // imagexPr = Image.FromFile(xPr);
        Image imagexPr = Properties.Resources.figura_x_pr;//Image.FromFile("JogoDaVelha.Resources.image-x-pr.png");
        Image imageoPr = Properties.Resources.figura_o_pr;//Image.FromFile("E:\\ETEC - CENTRO PAULA SOUZA\\JogoDaVelha\\imagens\\figura-o-pr.png");
        Image imagexBr = Properties.Resources.figura_x_br;// Image.FromFile("E:\\ETEC - CENTRO PAULA SOUZA\\JogoDaVelha\\imagens\\figura-x-br.png");
        Image imageoBr = Properties.Resources.figura_o_br;// Image.FromFile("E:\\ETEC - CENTRO PAULA SOUZA\\JogoDaVelha\\imagens\\figura-o-br.png");

        int jogada = 1;

        int[,] P = new int[3, 3] {{0, 0, 0},
                                  {0, 0, 0},
                                  {0, 0, 0}};

        public FrmJogoDaVelha()
        {
            InitializeComponent();
            BackColor = Color.White;
        }

        public void VerificacaoVitoria()
        {
            if ((P[0, 0] == 1 && P[0, 1] == 1 && P[0, 2] == 1) || (P[0, 0] == 2 && P[0, 1] == 2 && P[0, 2] == 2))
            {
                if (jogada % 2 == 0)
                {
                    if (MessageBox.Show("O JOGADOR 1 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    if (MessageBox.Show("O JOGADOR 2 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
            }

            else if ((P[1, 0] == 1 && P[1, 1] == 1 && P[1, 2] == 1) || (P[1, 0] == 2 && P[1, 1] == 2 && P[1, 2] == 2))
            {
                if (jogada % 2 == 0)
                {
                    if (MessageBox.Show("O JOGADOR 1 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    if (MessageBox.Show("O JOGADOR 2 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
            }

            else if ((P[2, 0] == 1 && P[2, 1] == 1 && P[2, 2] == 1) || (P[2, 0] == 2 && P[2, 1] == 2 && P[2, 2] == 2))
            {
                if (jogada % 2 == 0)
                {
                    if (MessageBox.Show("O JOGADOR 1 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    if (MessageBox.Show("O JOGADOR 2 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
            }

            else if ((P[0, 0] == 1 && P[1, 0] == 1 && P[2, 0] == 1) || (P[0, 0] == 2 && P[1, 0] == 2 && P[2, 0] == 2))
            {
                if (jogada % 2 == 0)
                {
                    if (MessageBox.Show("O JOGADOR 1 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    if (MessageBox.Show("O JOGADOR 2 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
            }

            else if ((P[0, 1] == 1 && P[1, 1] == 1 && P[2, 1] == 1) || (P[0, 1] == 2 && P[1, 1] == 2 && P[2, 1] == 2))
            {
                if (jogada % 2 == 0)
                {
                    if (MessageBox.Show("O JOGADOR 1 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    if (MessageBox.Show("O JOGADOR 2 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
            }

            else if ((P[0, 2] == 1 && P[1, 2] == 1 && P[2, 2] == 1) || (P[0, 2] == 2 && P[1, 2] == 2 && P[2, 2] == 2))
            {
                if (jogada % 2 == 0)
                {
                    if (MessageBox.Show("O JOGADOR 1 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    if (MessageBox.Show("O JOGADOR 2 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
            }

            else if ((P[0, 0] == 1 && P[1, 1] == 1 && P[2, 2] == 1) || (P[0, 0] == 2 && P[1, 1] == 2 && P[2, 2] == 2))
            {
                if (jogada % 2 == 0)
                {
                    if (MessageBox.Show("O JOGADOR 1 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    if (MessageBox.Show("O JOGADOR 2 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
            }

            else if ((P[0, 2] == 1 && P[1, 1] == 1 && P[2, 0] == 1) || (P[0, 2] == 2 && P[1, 1] == 2 && P[2, 0] == 2))
            {
                if (jogada % 2 == 0)
                {
                    if (MessageBox.Show("O JOGADOR 1 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    if (MessageBox.Show("O JOGADOR 2 VENCEU! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                    {
                        NovaPartida();
                    }
                    else
                    {
                        Close();
                    }
                }
            }

            else if ((P[0, 0] != 0) && (P[0, 1] != 0) && (P[0, 2] != 0) && (P[1, 0] != 0) && (P[1, 1] != 0) && (P[1, 2] != 0) && (P[2, 0] != 0) && (P[2, 1] != 0) && (P[2, 2] != 0))
            {
                if (MessageBox.Show("VELHA! Deseja tentar novamente?", "Resultado da Partida:", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                {
                    NovaPartida();
                }
                else
                {
                    Close();
                }
            }
        }

        public void NovaPartida()
        {
            jogada = 1;

            for (int l=0; l<=2; l++)
            {
                for (int c=0; c<=2; c++)
                {
                    P[l, c] = 0;
                }
            }

            pbP11.Image = null;
            pbP12.Image = null;
            pbP13.Image = null;
            pbP21.Image = null;
            pbP22.Image = null;
            pbP23.Image = null;
            pbP31.Image = null;
            pbP32.Image = null;
            pbP33.Image = null;
        }

        private void pbP11_Click(object sender, EventArgs e)
        {
            if (P[0, 0] == 0)
            {
                if (jogada % 2 == 1)
                {
                    P[0, 0] = 1;
                    if (BackColor == Color.White)
                    {
                        pbP11.Image = imagexPr;
                    }
                    else
                    {
                        pbP11.Image = imagexBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
                else
                {
                    P[0, 0] = 2;
                    if (BackColor == Color.White)
                    {
                        pbP11.Image = imageoPr;
                    }
                    else
                    {
                        pbP11.Image = imageoBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
            }
        }

        private void pbP12_Click(object sender, EventArgs e)
        {
            if (P[0, 1] == 0)
            {
                if (jogada % 2 == 1)
                {
                    P[0, 1] = 1;
                    if (BackColor == Color.White)
                    {
                        pbP12.Image = imagexPr;
                    }
                    else
                    {
                        pbP12.Image = imagexBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
                else
                {
                    P[0, 1] = 2;
                    if (BackColor == Color.White)
                    {
                        pbP12.Image = imageoPr;
                    }
                    else
                    {
                        pbP12.Image = imageoBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
            }    
        }

        private void pbP13_Click(object sender, EventArgs e)
        {
            if (P[0, 2] == 0)
            {
                if (jogada % 2 == 1)
                {
                    P[0, 2] = 1;
                    if (BackColor == Color.White)
                    {
                        pbP13.Image = imagexPr;
                    }
                    else
                    {
                        pbP13.Image = imagexBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
                else
                {
                    P[0, 2] = 2;
                    if (BackColor == Color.White)
                    {
                        pbP13.Image = imageoPr;
                    }
                    else
                    {
                        pbP13.Image = imageoBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
            }
        }

        private void pbP21_Click(object sender, EventArgs e)
        {
            if (P[1, 0] == 0)
            {
                if (jogada % 2 == 1)
                {
                    P[1, 0] = 1;
                    if (BackColor == Color.White)
                    {
                        pbP21.Image = imagexPr;
                    }
                    else
                    {
                        pbP21.Image = imagexBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
                else
                {
                    P[1, 0] = 2;
                    if (BackColor == Color.White)
                    {
                        pbP21.Image = imageoPr;
                    }
                    else
                    {
                        pbP21.Image = imageoBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
            }
            
        }

        private void pbP22_Click(object sender, EventArgs e)
        {
            if (P[1, 1] == 0)
            {
                if (jogada % 2 == 1)
                {
                    P[1, 1] = 1;
                    if (BackColor == Color.White)
                    {
                        pbP22.Image = imagexPr;
                    }
                    else
                    {
                        pbP22.Image = imagexBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
                else
                {
                    P[1, 1] = 2;
                    if (BackColor == Color.White)
                    {
                        pbP22.Image = imageoPr;
                    }
                    else
                    {
                        pbP22.Image = imageoBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
            }
        }

        private void pbP23_Click(object sender, EventArgs e)
        {
            if (P[1, 2] == 0)
            {
                if (jogada % 2 == 1)
                {
                    P[1, 2] = 1;
                    if (BackColor == Color.White)
                    {
                        pbP23.Image = imagexPr;
                    }
                    else
                    {
                        pbP23.Image = imagexBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
                else
                {
                    P[1, 2] = 2;
                    if (BackColor == Color.White)
                    {
                        pbP23.Image = imageoPr;
                    }
                    else
                    {
                        pbP23.Image = imageoBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
            }
        }

        private void pbP31_Click(object sender, EventArgs e)
        {
            if (P[2, 0] == 0)
            {
                if (jogada % 2 == 1)
                {
                    P[2, 0] = 1;
                    if (BackColor == Color.White)
                    {
                        pbP31.Image = imagexPr;
                    }
                    else
                    {
                        pbP31.Image = imagexBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
                else
                {
                    P[2, 0] = 2;
                    if (BackColor == Color.White)
                    {
                        pbP31.Image = imageoPr;
                    }
                    else
                    {
                        pbP31.Image = imageoBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
            }
        }

        private void pbP32_Click(object sender, EventArgs e)
        {
            if (P[2, 1] == 0)
            {
                if (jogada % 2 == 1)
                {
                    P[2, 1] = 1;
                    if (BackColor == Color.White)
                    {
                        pbP32.Image = imagexPr;
                    }
                    else
                    {
                        pbP32.Image = imagexBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
                else
                {
                    P[2, 1] = 2;
                    if (BackColor == Color.White)
                    {
                        pbP32.Image = imageoPr;
                    }
                    else
                    {
                        pbP32.Image = imageoBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
            }
        }

        private void pbP33_Click(object sender, EventArgs e)
        {
            if (P[2, 2] == 0)
            {
                if (jogada % 2 == 1)
                {
                    P[2, 2] = 1;
                    if (BackColor == Color.White)
                    {
                        pbP33.Image = imagexPr;
                    }
                    else
                    {
                        pbP33.Image = imagexBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
                else
                {
                    P[2, 2] = 2;
                    if (BackColor == Color.White)
                    {
                        pbP33.Image = imageoPr;
                    }
                    else
                    {
                        pbP33.Image = imageoBr;
                    }
                    jogada++;
                    VerificacaoVitoria();
                }
            } 
        }

        private void rbBranco_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.White;
            lbTitle.ForeColor = Color.Black;
            lbTemas.ForeColor = Color.Black;
            rbBranco.ForeColor = Color.Black;
            rbPreto.ForeColor = Color.Black;
            pbPrincipal.BackColor = Color.Black;
            btnReiniciar.BackColor = Color.White;
            btnReiniciar.ForeColor = Color.Black;

            /*for (int l=0; l<=2; l++)
            {
                for (int c=0; c<=2; c++)
                {
                    if (P[l, c] != 0)
                    {
                        if (P[l, c] == 1)
                        {
                            pbP11.Image = imagex;
                        }
                        else
                        {
                            pbP11.Image = imageo;
                        }
                    }
                }
            }*/

            if (P[0, 0] != 0)
            {
                if (P[0, 0] == 1)
                {
                    pbP11.Image = imagexPr;
                }
                else
                {
                    pbP11.Image = imageoPr;
                }
            }

            if (P[0, 1] != 0)
            {
                if (P[0, 1] == 1)
                {
                    pbP12.Image = imagexPr;
                }
                else
                {
                    pbP12.Image = imageoPr;
                }
            }

            if (P[0, 2] != 0)
            {
                if (P[0, 2] == 1)
                {
                    pbP13.Image = imagexPr;
                }
                else
                {
                    pbP13.Image = imageoPr;
                }
            }

            if (P[1, 0] != 0)
            {
                if (P[1, 0] == 1)
                {
                    pbP21.Image = imagexPr;
                }
                else
                {
                    pbP21.Image = imageoPr;
                }
            }

            if (P[1, 1] != 0)
            {
                if (P[1, 1] == 1)
                {
                    pbP22.Image = imagexPr;
                }
                else
                {
                    pbP22.Image = imageoPr;
                }
            }

            if (P[1, 2] != 0)
            {
                if (P[1, 2] == 1)
                {
                    pbP23.Image = imagexPr;
                }
                else
                {
                    pbP23.Image = imageoPr;
                }
            }

            if (P[2, 0] != 0)
            {
                if (P[2, 0] == 1)
                {
                    pbP31.Image = imagexPr;
                }
                else
                {
                    pbP31.Image = imageoPr;
                }
            }

            if (P[2, 1] != 0)
            {
                if (P[2, 1] == 1)
                {
                    pbP32.Image = imagexPr;
                }
                else
                {
                    pbP32.Image = imageoPr;
                }
            }

            if (P[2, 2] != 0)
            {
                if (P[2, 2] == 1)
                {
                    pbP33.Image = imagexPr;
                }
                else
                {
                    pbP33.Image = imageoPr;
                }
            }
        }

        private void rbPreto_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            lbTitle.ForeColor = Color.White;
            lbTemas.ForeColor = Color.White;
            rbBranco.ForeColor = Color.White;
            rbPreto.ForeColor = Color.White;
            pbPrincipal.BackColor = Color.White;
            btnReiniciar.BackColor = Color.Black;
            btnReiniciar.ForeColor = Color.White;

            /*for (int l = 0; l <= 2; l++)
            {
                for (int c = 0; c <= 2; c++)
                {
                    if (P[l, c] != 0)
                    {
                        if (P[l, c] == 1)
                        {
                            pbP11.Image = imagex;
                        }
                        else
                        {
                            pbP11.Image = imageo;
                        }
                    }
                }
            }*/

            if (P[0, 0] != 0)
            {
                if (P[0, 0] == 1)
                {
                    pbP11.Image = imagexBr;
                }
                else
                {
                    pbP11.Image = imageoBr;
                }
            }

            if (P[0, 1] != 0)
            {
                if (P[0, 1] == 1)
                {
                    pbP12.Image = imagexBr;
                }
                else
                {
                    pbP12.Image = imageoBr;
                }
            }

            if (P[0, 2] != 0)
            {
                if (P[0, 2] == 1)
                {
                    pbP13.Image = imagexBr;
                }
                else
                {
                    pbP13.Image = imageoBr;
                }
            }

            if (P[1, 0] != 0)
            {
                if (P[1, 0] == 1)
                {
                    pbP21.Image = imagexBr;
                }
                else
                {
                    pbP21.Image = imageoBr;
                }
            }

            if (P[1, 1] != 0)
            {
                if (P[1, 1] == 1)
                {
                    pbP22.Image = imagexBr;
                }
                else
                {
                    pbP22.Image = imageoBr;
                }
            }

            if (P[1, 2] != 0)
            {
                if (P[1, 2] == 1)
                {
                    pbP23.Image = imagexBr;
                }
                else
                {
                    pbP23.Image = imageoBr;
                }
            }

            if (P[2, 0] != 0)
            {
                if (P[2, 0] == 1)
                {
                    pbP31.Image = imagexBr;
                }
                else
                {
                    pbP31.Image = imageoBr;
                }
            }

            if (P[2, 1] != 0)
            {
                if (P[2, 1] == 1)
                {
                    pbP32.Image = imagexBr;
                }
                else
                {
                    pbP32.Image = imageoBr;
                }
            }

            if (P[2, 2] != 0)
            {
                if (P[2, 2] == 1)
                {
                    pbP33.Image = imagexBr;
                }
                else
                {
                    pbP33.Image = imageoBr;
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            NovaPartida();
        }
    }
}
