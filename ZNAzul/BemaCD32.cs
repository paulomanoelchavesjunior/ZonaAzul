using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace BemaCD32_LT9800
{
    class BemaCD32
    {
        #region Funções Gerais

        /// <summary>
        /// Limpa o Display e posiciona o cursor no canto superior esquerdo
        /// </summary>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_LimpaDisplay();

        /// <summary>
        /// Move o cursor para a direita ou esquerda a partir da posição onde está.
        /// </summary>
        /// <param name="Direction">STRING Direção de movimentação do Cursor: "E" - Esquerda, "D" - Direita</param>
        /// <param name="Position">INTEIRO Quantidade   de   colunas  que o cursor será movido</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_MoveCursor(string direction, int position);

        /// <summary>
        /// Oculta o cursor do display.
        /// </summary>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_ApagaCursor();

        /// <summary>
        /// Mostra o cursor no Display
        /// </summary>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_MostraCursor();

        /// <summary>
        /// Define o modo de apresentação do cursor no display
        /// </summary>
        /// <param name="modoCursor">INTEIRO Modo de apresentação do cursor 0 - Sublinhado, 1 - Bloco Piscante</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_ModoCursor(int modoCursor);

        /// <summary>
        /// Move todo o texto no display para a esquerda ou direita
        /// </summary>
        /// <param name="direcao">STRINGDireção de movimentação do cursor: E - Esquerda, D - Direita</param>
        /// <param name="posicao">INTEIRO Quantidade de colunas que o texto será movido</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_MoveTexto(string direcao, int posicao);

        /// <summary>
        /// Escreve um texto no display iniciando na linha e coluna especificada.
        /// </summary>
        /// <param name="texto">STRING texto com até 40 caracteres</param>
        /// <param name="linha">INTEIRO Linha em que o texto será escrito</param>
        /// <param name="coluna">INTEIRO Coluna   inicial   em   que  o  texto  será escrito</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_EnviaTexto(string texto, int linha, int coluna);

        /// <summary>
        /// Essa função passa um texto no display. O texto aparece do lado esquerdo e some do lado direito. Você pode configurar a velocidade da passagem do texto e o número de vezes em que o mesmo será apresentado.
        /// </summary>
        /// <param name="texto">STRING texto com até 40 caracteres</param>
        /// <param name="numeroVezes">INTEIRO Número   de   vezes  que  o  texto  será mostrado.</param>
        /// <param name="velocidade">INTEIRO Velocidade da  passagem  do texto que compreende 0 ms (milésimo de segundo) até 30 segundos. O valor deve ser informado em  milésimos de segundo. Por exemplo: Se você que agurdar  1  segundo  você  deve  passar 1000 ms.</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_PassaTexto(string texto, int numeroVezes, int velocidade);

        /// <summary>
        /// Essa função faz o texto piscar no display. Você pode configurar a velocidade e o número de vezes que o texto irá piscar.
        /// </summary>
        /// <param name="texto">STRING texto com até 40 caracteres</param>
        /// <param name="numeroVezes">INTEIRO Número   de   vezes  que  o  texto  será mostrado.</param>
        /// <param name="velocidade">INTEIRO Velocidade da  passagem  do texto que compreende     0     ms     (milésimo     de segundo)   até   30   segundos.   O   valor deve  ser  informado  em  milésimos  de segundo.  Por  exemplo:  Se  você  que agurdar  1  segundo  você  deve  passar 1000 ms.</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_PiscaTexto(string texto, int numeroVezes, int velocidade);

        /// <summary>
        /// Essa  função   permite   escrever   um   texto   centralizado   no   display.   Você pode configurar a linha a ser centralizada.
        /// </summary>
        /// <param name="texto">STRING texto com até 40 caracteres</param>
        /// <param name="linha">INTEIRO Linha de texto a ser centralizada: 1 – Centraliza o texto da linha 1, 2 – Centraliza o texto da linha 2, 3 – Centraliza o texto de ambas as linhas.</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_CentralizaTexto(string texto, int linha);

        /// <summary>
        /// Essa função passa letra a letra no display, formando o texto final da esquerda para a  direita.  Você pode  configurar  a  posição  inicial  do  texto  e  a  velocidade  de passagem da letra.</param>
        /// </summary>
        /// <param name="texto">STRING texto com até 40 caracteres</param>
        /// <param name="posInicial">INTEIRO Coluna inicial onde o texto será escrito.</param>
        /// <param name="velocidade">INTEIRO Velocidade    em     que    a    letra    irá movimentar-se no display. Inteiro  entre  0  ms  (milisegundos)  até 30 segundos (30000 ms). O valor deve ser    informado    em    milésimos    de segundo.  Por  exemplo:  Se  você  que agurdar  1  segundo  você  deve  passar 1000 ms.</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_LetraALetra(string texto, int posInicial, int velocidade);

        /// <summary>
        /// Essa função  e  a  função  Bematech_CD_SomaPreco()  são  funções  que  simulam, por  exemplo,  um  caixa  de  supermercado  onde  os  produtos  são  passados  e  os valores  são  somados.  A  função  Bematech_CD_FixaPreco()  fixa,  por  exemplo,  a palavra “SubTotal” no display enquanto os produtos são passados e somados pela função Bematech_CD_SomaPreco().
        /// </summary>
        /// <param name="texto">STRING String com até 10 caracteres contendo o  texto  a  ser   fixado   no  display. Por exemplo: “SubTotal:”</param>
        /// <param name="linha">INTEIRO Linha em que o texto será fixado: 1 – Linha 1, 2 – Linha 2. </param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_FixaPreco(string texto, int linha);

        /// <summary>
        /// Essa função mostra o nome e o valor do produto no display, soma o valor e mostra o  subtotal  ou  o  total  da  soma  alinhado  a  direita  na  frente  do  texto  fixado  pela função Bematech_CD_FixaPreco().
        /// </summary>
        /// <param name="texto">STRING String  até 11 caracteres com o nome do produto</param>
        /// <param name="valor">STRING Valor   do  produto  que  será   somado pela  função  e  totalizado  a  frente  do texto fixado</param>
        /// <param name="textoFinal">STRING String  a  ser escrita  para  descrever  o total   da   soma.   Esse parâmetro   é necessário       somente       quando       o parâmetro “Finaliza” for igual a 1 (um).</param>
        /// <param name="finaliza">INTEIRO Valor indicando se é para finalizar ou não a soma dos valores: 0 – Continua somando os valores, 1 – Indica  para  a  função  finalizar a soma e mostrar o valor total. Nesse momento o parâmetro “TextoFinal” torna-se obrigatório. Nesse momento o  texto fixado será apagado. </param>
        /// <param name="valorFinal ">INTEIRO Variável    para   receber   o    valor   do subtotal ou do total da soma.</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_SomaPreco(string texto, string valor, int finaliza, string textoFinal, ref int valorFinal);

        /// <summary>
        /// Abre a porta serial para comunicação entre o display e o micro.
        /// </summary>
        /// <param name="porta">STRING String com o nome da porta COM a ser ativada, por exemplo “COM 1” .</param>                                      
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_AbrePortaSerial(string porta);

        /// <summary>
        /// Fecha a porta serial.
        /// </summary>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_FechaPortaSerial();

        /// <summary>
        /// Posiciona o cursor numa determinada linha e coluna.
        /// </summary>
        /// <param name="iPorta">INTEIRO Linha onde o cursor deverá ser posicionado ( 1 ou 2 ).</param>
        /// <param name="iColuna">INTEIRO Coluna onde o cursor deverá ser posicionado ( de 1 a 40 ).</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_PosicionaCursor(int iLinha, int iColuna);

        /// <summary>
        /// Permite ao desenvolvedor enviar comandos diretamente para o display. 
        /// </summary>
        /// <param name="cComando">STRING Comando que será enviado ao display </param>
        /// <param name="iTamanhoComando">INTEIRO Tamanho do comando que será enviado ( permite o envio de ‘\0’ como comando ) </param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_EnviaComando(string cComando, int iTamanhoComando);

        /// <summary>
        /// Permite ao desenvolvedor escolher o modelo do display. 
        /// </summary>
        /// <param name="iModelo">INTEIRO Modelo do display: 20 - VC-20, 21 - BPD100, 22 - LT-9800</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_ConfiguraModelo(int iModelo);

        /// <summary>
        /// Permite ao desenvolvedor selecionar uma fonte na tabela de fontes internacional. 
        /// </summary>
        /// <param name="iTipoCaracter">INTEIRO Código da fonte escolhida: 0 – U.S.A, 2 – GERMANY, 3 – U.K, 4 – DENMARK I, 5 – SWEDEN, 6 – ITALY, 7 – SPAIN, 8 – JAPAN, 9 – NORWAY, 10 – DENMARK II</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_SelecionaTipoCaracter(int iTipoCaracter);

        /// <summary>
        /// Permite ao desenvolvedor escolher o BaudRate ( 9600 ou 19200 ).
        /// </summary>
        /// <param name="baudeRate">INTEIRO BaudRate desejado ( 9600 ou 19200 ).</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_SetBaudRate(int baudeRate);

        /// <summary>
        /// Seleciona o modo de escrita no Display LT9800.
        /// </summary>
        /// <param name="modo">INTEIRO -> modo de escrita normal, 2 -> modo de escrita vertical</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_SelecionaModoEscrita(int modo);

        /// <summary>
        /// Altera o brilho do Display LT9800.
        /// </summary>
        /// <param name="modo">INTEIRO 0 -> 20%, 1 -> 40%, 2 -> 60%, 3 -> 100% </param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_AlteraBrilhoDisplay(int modo);

        /// <summary>
        /// Apaga o(s) caractere(s) que estiver(em) antes do cursor, semelhante ao Backspace.
        /// </summary>
        /// <param name="quantidade">INTEIRO Quantidade de caracteres a serem apagados.</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_ApagaCaracter(int quantidade);

        /// <summary>
        /// Insere a quantidade de espaços informada.
        /// </summary>
        /// <param name="quantidade">INTEIRO Quantidade de espaços a serem apagados.</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_InsereEspacos(int quantidade);

        /// <summary>
        /// - No Modo Vertical -> Desloca a linha de baixo para a de cima e cria uma nova linha em branco mantendo o cursor na coluna corrente. No Modo Horizontal -> Posiciona o cursor na outra linha na mesma coluna.
        /// </summary>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_NovaLinha();

        /// <summary>
        /// Posiciona o cursor no inicio da linha corrente
        /// </summary>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_InicioLinha();

        /// <summary>
        /// Configurar o modo de exibição do display LT-9800 (frontal, traseiro ou ambos).
        /// </summary>
        /// <param modo="modo">INTEIRO 1 - Ambos os displays, 2 - Somente display traseiro, 2 -Somente display frontal</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_ConfiguraModoExibicao(int modo);

        /// <summary>
        /// Mostra relógio na segunda linha com a hora e minutos informados no formato de 12 horas
        /// </summary>
        /// <param modo="hora">STRING hora no formato hh</param>
        /// <param modo="minuto">STRING minutos no formato mm.</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_ExibeRelogio(string hora, string minuto);

        /// <summary>
        /// Configurar o modo de exibição do display LT-9800 (frontal, traseiro ou ambos).
        /// </summary>
        /// <param modo="texto">STRING Texto a ser exibido.</param>
        /// <param modo="linha">INTEIRO  linha em que o texto será exibido (1 ou 2).</param>
        /// <param modo="direcao">INTEIRO 1 - direita para a esquerda, 2 - esquerda para a direita</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_DeslizaTexto(String texto, int linha, int direcao);

        /// <summary>
        /// Exibe dois textos deslizando pelo display em sequencia.
        /// </summary>
        /// <param modo="texto1">STRING Primeiro texto a ser exibido</param>
        /// <param modo="texto2">STRING Segundo texto a ser exibido</param>
        /// <param modo="linha">INTEIRO  linha em que o texto será exibido (1 ou 2).</param>
        /// <param modo="direcao">INTEIRO 1 - direita para a esquerda, 2 - esquerda para a direita</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_DeslizaDoisTextos(String texto1, String texto2, int linha, int direcao);

        /// <summary>
        /// Reseta o display LT-9800.
        /// </summary>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_ResetaDisplay();

        /// <summary>
        /// Função altera um caractere para um modo customizado.
        /// </summary>
        /// <param modo="caractere">STRING Caractere que será substituído</param>
        /// <param modo="byte1">STRING Segundo texto a ser exibido</param>
        /// <param modo="byte2">INTEIRO Código entre 0 e 0xFF.</param>
        /// <param modo="byte3">INTEIRO Código entre 0 e 0xFF.</param>
        /// <param modo="byte4">INTEIRO Código entre 0 e 0xFF.</param>
        /// <param modo="byte5">INTEIRO Código entre 0 e 0xFF.</param>
        /// <returns>INTEIRO - Indica se a função conseguiu enviar o comando para impressora.</returns>
        [DllImport("BemaCD32.dll")]
        public static extern int Bematech_CD_DeslizaDoisTextos(string caractere, int byte1, int byte2, int byte3, int byte4, int byte5);

        #endregion
    }
}
