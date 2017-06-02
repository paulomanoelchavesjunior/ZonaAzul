using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZNAzul
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();

            cbLogradouto.Items.Insert(0, "AVENIDA ARCO IRIS");
            cbLogradouto.Items.Insert(1, "AVENIDA DA SAUDADE");
            cbLogradouto.Items.Insert(2, "AVENIDA DOS COQUEIROS");
            cbLogradouto.Items.Insert(3, "AVENIDA DOS EXPEDICIONARIOS");
            cbLogradouto.Items.Insert(4, "AVENIDA GIOVANI RINALDI");
            cbLogradouto.Items.Insert(5, "AVENIDA ISRAEL");
            cbLogradouto.Items.Insert(6, "AVENIDA LIBERDADE");
            cbLogradouto.Items.Insert(7, "AVENIDA ORLANDO AMOROSO");
            cbLogradouto.Items.Insert(8, "AVENIDA PACAEMBU");
            cbLogradouto.Items.Insert(9, "AVENIDA SAO PAULO");
            cbLogradouto.Items.Insert(10, "AVENIDA SERRANA");
            cbLogradouto.Items.Insert(11, "AVENIDA SETE DE SETEMBRO");
            cbLogradouto.Items.Insert(12, "AVENIDA WASHINGTON LUIZ");
            cbLogradouto.Items.Insert(13, "BOULEVARD JULIANO CECCHETTINI");
            cbLogradouto.Items.Insert(14, "ESTRADA DA CACEIA");
            cbLogradouto.Items.Insert(15, "ESTRADA DA VARGEM GRANDE");
            cbLogradouto.Items.Insert(16, "ESTRADA DO GOVERNO");
            cbLogradouto.Items.Insert(17, "ESTRADA ETTORE PALMA");
            cbLogradouto.Items.Insert(18, "ESTRADA MARIO CRUZ");
            cbLogradouto.Items.Insert(19, "ESTRADA MUNICIPAL BOM TEMPO");
            cbLogradouto.Items.Insert(20, "ESTRADA MUNICIPAL DE VARGEM GRANDE");
            cbLogradouto.Items.Insert(21, "ESTRADA MUNICIPAL FRANCO DA ROCHA");
            cbLogradouto.Items.Insert(22, "PARQUE DA CIDADANIA");
            cbLogradouto.Items.Insert(23, "PARQUE DA LIBERDADE");
            cbLogradouto.Items.Insert(24, "PRACA ALEXANDRE BOTINELLI");
            cbLogradouto.Items.Insert(25, "PRACA CAIEIRAS");
            cbLogradouto.Items.Insert(26, "PRACA DOM BOSCO");
            cbLogradouto.Items.Insert(27, "PRACA DOMINGOS ANTONIO LOPES");
            cbLogradouto.Items.Insert(28, "PRACA MINISTRO NELSON HUNGIRA");
            cbLogradouto.Items.Insert(29, "PRACA OS CACADORES DA NATUREZA PERDIDA");
            cbLogradouto.Items.Insert(30, "RODOVIA PREFEITO LUIZ SALOMAO CHAMMA");
            cbLogradouto.Items.Insert(31, "RUA ABELARDO ALVES DE ANDRADE");
            cbLogradouto.Items.Insert(32, "RUA ALBERT EINSTEIN");
            cbLogradouto.Items.Insert(33, "RUA ALBERTO FEDERZONI");
            cbLogradouto.Items.Insert(34, "RUA ALCEU ANZELOTTI");
            cbLogradouto.Items.Insert(35, "RUA ALEXANDRE DUMAS");
            cbLogradouto.Items.Insert(36, "RUA AMADOR BUENO");
            cbLogradouto.Items.Insert(37, "RUA AMALIA TARAMELI CORSI");
            cbLogradouto.Items.Insert(38, "RUA ANA SIERRA DINIZ");
            cbLogradouto.Items.Insert(39, "RUA ANTONIO CARDOSO MOREIRA");
            cbLogradouto.Items.Insert(40, "RUA ANTONIO IGNACIO BICUDO");
            cbLogradouto.Items.Insert(41, "RUA APOLO");
            cbLogradouto.Items.Insert(42, "RUA ARGENTINA");
            cbLogradouto.Items.Insert(43, "RUA ARMANDO PINTO");
            cbLogradouto.Items.Insert(44, "RUA ARMANDO SESTINI");
            cbLogradouto.Items.Insert(45, "RUA ARTHUR SESTINI");
            cbLogradouto.Items.Insert(46, "RUA AZEVEDO SOARES");
            cbLogradouto.Items.Insert(47, "RUA BENEDITO FAGUNDES MARQUES");
            cbLogradouto.Items.Insert(48, "RUA BENJAMIN CONSTANT");
            cbLogradouto.Items.Insert(49, "RUA BOGOTA");
            cbLogradouto.Items.Insert(50, "RUA BORBA GATO");
            cbLogradouto.Items.Insert(51, "RUA BRAS CUBAS");
            cbLogradouto.Items.Insert(52, "RUA CAVALHEIRO ANGELO SESTINI");
            cbLogradouto.Items.Insert(53, "RUA CEARA");
            cbLogradouto.Items.Insert(54, "RUA CHARLES DICKENS");
            cbLogradouto.Items.Insert(55, "RUA CHILE");
            cbLogradouto.Items.Insert(56, "RUA CINCO DE MAIO");
            cbLogradouto.Items.Insert(57, "RUA CLOVIS BEVILAQUA");
            cbLogradouto.Items.Insert(58, "RUA CORIPHEU DE AZEVEDO MARQUES");
            cbLogradouto.Items.Insert(59, "RUA CORONEL DOMINGOS ORTIZ");
            cbLogradouto.Items.Insert(60, "RUA CORONEL FAGUNDES");
            cbLogradouto.Items.Insert(61, "RUA DAS MARGARIDAS");
            cbLogradouto.Items.Insert(62, "RUA DAVID CAVALHEIRO");
            cbLogradouto.Items.Insert(63, "RUA DIADEMA");
            cbLogradouto.Items.Insert(64, "RUA DINAMARCA");
            cbLogradouto.Items.Insert(65, "RUA DOMINGOS ANTONIO LOPES");
            cbLogradouto.Items.Insert(66, "RUA DONA AMALIA SESTINI");
            cbLogradouto.Items.Insert(67, "RUA DOUTOR ARMANDO PINTO");
            cbLogradouto.Items.Insert(68, "RUA DOUTOR FRANCO DA ROCHA");
            cbLogradouto.Items.Insert(69, "RUA DOUTOR HAMILTON PRADO");
            cbLogradouto.Items.Insert(70, "RUA DOUTORA APPARECIDA LEOPOLDO DA SILVA");
            cbLogradouto.Items.Insert(71, "RUA DOZE DE OUTUBRO");
            cbLogradouto.Items.Insert(72, "RUA DR. BASILIO FAZZI");
            cbLogradouto.Items.Insert(73, "RUA EMILE ZOLA");
            cbLogradouto.Items.Insert(74, "RUA ENGENHEIRO JOAO BATISTA GARCEZ");
            cbLogradouto.Items.Insert(75, "RUA ERNEST STEINKOPFF");
            cbLogradouto.Items.Insert(76, "RUA EUCLIDES DA CUNHA");
            cbLogradouto.Items.Insert(77, "RUA FALIEIRO DEL DEBBIO");
            cbLogradouto.Items.Insert(78, "RUA FLORIANO PEIXOTO");
            cbLogradouto.Items.Insert(79, "RUA FRANCA ");
            cbLogradouto.Items.Insert(80, "RUA FRANCISCO CASAMASSA");
            cbLogradouto.Items.Insert(81, "RUA FRANCISCO FERNANDES PESSOLANO");
            cbLogradouto.Items.Insert(82, "RUA FRANCISCO MATHIAS");
            cbLogradouto.Items.Insert(83, "RUA GENERAL RONDON");
            cbLogradouto.Items.Insert(84, "RUA GENERAL VICENTE DE PAULA DALE COUTINHO");
            cbLogradouto.Items.Insert(85, "RUA GENTIL ROCHA");
            cbLogradouto.Items.Insert(86, "RUA GRECIA");
            cbLogradouto.Items.Insert(87, "RUA HIPOLITO TRIGO SANTIAGO");
            cbLogradouto.Items.Insert(88, "RUA INDALECIO GUMERCINDO DA CUNHA");
            cbLogradouto.Items.Insert(89, "RUA ISLANDIA");
            cbLogradouto.Items.Insert(90, "RUA JAIME DUPRAT");
            cbLogradouto.Items.Insert(91, "RUA JOAO RAIS");
            cbLogradouto.Items.Insert(92, "RUA JOSE ALVES DE CERQUEIRA CESAR");
            cbLogradouto.Items.Insert(93, "RUA JOSE ALVES FERREIRA FILHO");
            cbLogradouto.Items.Insert(94, "RUA JOSE AUGUSTO MOREIRA");
            cbLogradouto.Items.Insert(95, "RUA JOSE NICODEMO");
            cbLogradouto.Items.Insert(96, "RUA JOSE PRIMO LERUSSI");
            cbLogradouto.Items.Insert(97, "RUA JOSE QUINTANILHA");
            cbLogradouto.Items.Insert(98, "RUA JOSE ROBERTO ROSA");
            cbLogradouto.Items.Insert(99, "RUA JUVENAL GOMES DUMONT");
            cbLogradouto.Items.Insert(100, "RUA LEONILDA BALDIN");
            cbLogradouto.Items.Insert(101, "RUA LIDIA DOS SANTOS");
            cbLogradouto.Items.Insert(102, "RUA LUCAS VIEIRAS");
            cbLogradouto.Items.Insert(103, "RUA LUIZ COUTINHO DE ABREU");
            cbLogradouto.Items.Insert(104, "RUA LUIZ UVALDO GONCALVES");
            cbLogradouto.Items.Insert(105, "RUA LUIZ VITAL TREVISAN");
            cbLogradouto.Items.Insert(106, "RUA MARECHAL CANDIDO RONDON");
            cbLogradouto.Items.Insert(107, "RUA MARINO TARDELLI");
            cbLogradouto.Items.Insert(108, "RUA MAXIMO GORKI");
            cbLogradouto.Items.Insert(109, "RUA MERCURIO");
            cbLogradouto.Items.Insert(110, "RUA MEXICO");
            cbLogradouto.Items.Insert(111, "RUA MONTEIRO LOBATO");
            cbLogradouto.Items.Insert(112, "RUA NELSON RODRIGUES");
            cbLogradouto.Items.Insert(113, "RUA NILO PECONHA");
            cbLogradouto.Items.Insert(114, "RUA NOBREGA");
            cbLogradouto.Items.Insert(115, "RUA NOVE DE JULHO");
            cbLogradouto.Items.Insert(116, "RUA PADRE VIEIRA");
            cbLogradouto.Items.Insert(117, "RUA PAOLI");
            cbLogradouto.Items.Insert(118, "RUA PEDRO ALVARES CABRAL");
            cbLogradouto.Items.Insert(119, "RUA PERICLES FERNANDES PEREIRA");
            cbLogradouto.Items.Insert(120, "RUA PERNAMBUCO");
            cbLogradouto.Items.Insert(121, "RUA PORTUGAL");
            cbLogradouto.Items.Insert(122, "RUA PROFESSOR CARLOS OLIVEIRA");
            cbLogradouto.Items.Insert(123, "RUA PROFESSOR CARVALHO PINTO");
            cbLogradouto.Items.Insert(124, "RUA RANGEL PESTANA");
            cbLogradouto.Items.Insert(125, "RUA RAUL BRESSANI MALTA");
            cbLogradouto.Items.Insert(126, "RUA ROUSSEAU");
            cbLogradouto.Items.Insert(127, "RUA STELIO MACHADO LOUREIRO");
            cbLogradouto.Items.Insert(128, "RUA TAUBATE");
            cbLogradouto.Items.Insert(129, "RUA TIRADENTES");
            cbLogradouto.Items.Insert(130, "RUA TOLSTOI");
            cbLogradouto.Items.Insert(131, "RUA TOMAS ANTONIO GONZAGA");
            cbLogradouto.Items.Insert(132, "RUA TONICO LENCI");
            cbLogradouto.Items.Insert(133, "RUA TRINTA DE NOVEMBRO");
            cbLogradouto.Items.Insert(134, "RUA VEREADOR SIDNEI SIMIONATO");
            cbLogradouto.Items.Insert(135, "RUA XAVANTES");
            cbLogradouto.Items.Insert(136, "RUA ZANELA E ALVES");
            cbLogradouto.Items.Insert(137, "RUA ZEBEDEU MARCOLINO");
            cbLogradouto.Items.Insert(138, "TRAVESSA JOAO RODRIGUES DE MORAES");
            cbLogradouto.Items.Insert(139, "TRAVESSA RUI BARBOSA");
            cbLogradouto.Items.Insert(140, "VIADUTO DONALD SAVAZONI");


            cbMotivoInfracao.Items.Insert(0, "Alinhamento irregular do veículo");
            cbMotivoInfracao.Items.Insert(1, "Cartão de estacionamento Rasurado");
            cbMotivoInfracao.Items.Insert(2, "Descricao");
            cbMotivoInfracao.Items.Insert(3, "Falta de Cartão de Estacionamento");
            cbMotivoInfracao.Items.Insert(4, "Outras Irregularidades");
            cbMotivoInfracao.Items.Insert(5, "Período ultrapassado");
            cbMotivoInfracao.Items.Insert(6, "Preenchimento do cartão de estacionamento com Lápis");
            cbMotivoInfracao.Items.Insert(7, "Preenchimento Irregular do Cartão de Estacionamento");
            cbMotivoInfracao.Items.Insert(8, "Renovação de cartão na mesma vaga");
            cbMotivoInfracao.Items.Insert(9, "Vestígios de duplo aproveitamento do cartão de estacionamento ");

            txtNumeroAviso.Mask = "L.0000000";
            txtNumeroAviso.MaskInputRejected += new MaskInputRejectedEventHandler(txtNumeroAviso_MaskInputRejected);

            txtHora.Mask = "00:00";
            txtHora.MaskInputRejected += new MaskInputRejectedEventHandler(txtHora_MaskInputRejected);

            txtPlaca.Mask = "LLL-0000";
            txtPlaca.MaskInputRejected += new MaskInputRejectedEventHandler(txtPlaca_MaskInputRejected);
        }

        void txtHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Data Inválida";
            toolTip1.Show("Digite Uma data Correta.", txtHora, txtHora.Location, 5000);
        }

        void txtNumeroAviso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Número Aviso Inválida";
            toolTip1.Show("Digite um número aviso.", txtHora, txtHora.Location, 5000);
        }

        void txtPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Número placa Inválida";
            toolTip1.Show("Digite uma placa aviso.", txtPlaca, txtPlaca.Location, 5000);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\paulo.chaves\\Desktop\\SITE\\Imprimir.htm");
        }
    }
}
