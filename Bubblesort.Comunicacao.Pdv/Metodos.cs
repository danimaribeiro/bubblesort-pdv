using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DFW
{
    public class Declaracoes
    {
        public static int iRetorno;
        public static string sBuffer = string.Empty;
        public static string Str_LabelInputBox, Str_TextoInputBox, Str_Retorno_InputBox;
        public static string Str_Aleatorio;
        public static int iAleatorio;

        public static string InputBox(string LB_stringInputBox, string TB_InputBox)
        {
            Str_LabelInputBox = string.Empty;
            Str_TextoInputBox = string.Empty;
            Str_Retorno_InputBox = string.Empty;

            Str_LabelInputBox = LB_stringInputBox;
            Str_TextoInputBox = TB_InputBox;

            return Str_Retorno_InputBox;
        }


        public static string TrataRetorno(int intRetorno)
        {
            int Int_NumErro = 0;
            int Int_NumAviso = 0;

            StringBuilder Str_Msg_Retorno_Metodo = new StringBuilder(300);
            StringBuilder Str_Msg_NumErro = new StringBuilder(300);
            StringBuilder Str_Msg_NumAviso = new StringBuilder(300);

                rStatusUltimoCmdInt_ECF_Daruma(ref Int_NumErro, ref Int_NumAviso);
                eInterpretarErro_ECF_Daruma(Int_NumErro,Str_Msg_NumErro);
                eInterpretarAviso_ECF_Daruma(Int_NumAviso,Str_Msg_NumAviso);
                eInterpretarRetorno_ECF_Daruma(intRetorno, Str_Msg_Retorno_Metodo);
                

       return "Retorno do Metodo = " + Str_Msg_Retorno_Metodo + "\r\n" + "Num.Erro = " + Str_Msg_NumErro + "\r\n" + "Num.Aviso= " + Str_Msg_NumAviso;
           
          
        }

        #region Métodos DarumaFramework

        [DllImport("DarumaFrameWork.dll")]
        public static extern int eDefinirProduto_Daruma(string sProduto);

        [DllImport("DarumaFrameWork.dll")]
        public static extern int regRetornaValorChave_DarumaFramework(string sProduto, string sChave, StringBuilder szRetorno);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regSintegra_ECF_Daruma(string sChave, string sValor);


        #endregion

        #region Métodos DUAL

        public static string NaoFiscal_Mostrar_Retorno(int iRetorno)
        {
            string vRet = string.Empty;

            if (iRetorno == 1 | iRetorno == 0 | iRetorno == -27 | iRetorno == -50 | iRetorno == 51 | iRetorno == 52)
                switch (iRetorno)
                {
                    case 0: vRet = "0(zero) - Impressora Desligada!";
                        break;
                    //case 1: TB_Status.Text = "1(um) - Impressora OK!";
                    //    break;
                    case -50: vRet = "-50 - Impressora OFF-LINE!";
                        break;
                    case -51: vRet = "-51 - Impressora Sem Papel!";
                        break;
                    case -27: vRet = "-27 - Erro Generico!";
                        break;
                    case -52: vRet = "-52 - Impressora inicializando!";
                        break;
                }

            else
            {
                vRet = "Retorno não esperado!";
            }

            return vRet;
        }
        //*************Métodos para Impressoras Dual*************

        [DllImport("DarumaFrameWork.dll")]
        public static extern int iEnviarBMP_DUAL_DarumaFramework(string stArqOrigem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iImprimirArquivo_DUAL_DarumaFramework(string stPath);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iAcionarGaveta_DUAL_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusGaveta_DUAL_DarumaFramework(ref int iStatusGaveta);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusDocumento_DUAL_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusImpressora_DUAL_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regVelocidade_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regTermica_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regTabulacao_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regPortaComunicacao_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regModoGaveta_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regLinhasGuilhotina_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regEnterFinal_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regAguardarProcesso_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iImprimirTexto_DUAL_DarumaFramework(string stTexto, int iTam);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iAutenticarDocumento_DUAL_DarumaFramework(string stTexto, string stLocal, string stTimeOut);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCodePageAutomatico_DUAL_DarumaFramework(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regZeroCortado_DUAL_DarumaFramework(System.String stParametro);

        #endregion

        #region Métodos TA2000

        //*************Método TA2000*************

        //[DllImport("DarumaFrameWork.dll")]
        //public static extern int iEnviarDadosFormatados_TA2000_Daruma(string szTexto, string szRetorno);

        // Declaracao da Variavel por Referencia
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iEnviarDadosFormatados_TA2000_Daruma(System.String szTexto, StringBuilder szRetorno);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regPorta_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regAuditoria_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMensagemBoasVindasLinha1_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMensagemBoasVindasLinha2_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMarcadorOpcao_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMascara_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMascaraLetra_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMascaraNumero_TA2000_Daruma(System.String stParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMascaraEco_TA2000_Daruma(System.String stParametro);

        #endregion

        #region Métodos Modem


        [DllImport("DarumaFrameWork.dll")]
        public static extern int regLerApagar_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regPorta_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regThread_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regVelocidade_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regTempoAlertar_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCaptionWinAPP_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regBandejaInicio_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eInicializar_MODEM_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eTrocarBandeja_MODEM_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eApagarSms_MODEM_DarumaFramework(System.String iNumeroSMS);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rListarSms_MODEM_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rNivelSinalRecebido_MODEM_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rReceberSms_MODEM_DarumaFramework(StringBuilder sIndiceSMS, StringBuilder sNumFone, StringBuilder sData, StringBuilder sHora, StringBuilder sMsg);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rRetornarImei_MODEM_DarumaFramework(StringBuilder sImei);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rRetornarOperadora_MODEM_DarumaFramework(StringBuilder sOperadora);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tEnviarSms_MODEM_DarumaFramework(System.String sNumeroTelefone, System.String sMensagem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tEnviarDadosCsd_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rReceberDadosCsd_MODEM_DarumaFramework(System.String sParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eAtivarConexaoCsd_MODEM_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eFinalizarChamadaCsd_MODEM_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eRealizarChamadaCsd_MODEM_DarumaFramework(System.String sParametro);
        #endregion

        #region Métodos Impressora Fiscal
        // --- Especiais - Inicio --- 
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eInterpretarErro_ECF_Daruma(int iErro, StringBuilder pszDescErro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eInterpretarAviso_ECF_Daruma(int iAviso, StringBuilder pszDescAviso);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eInterpretarRetorno_ECF_Daruma(int iRetorno, StringBuilder pszDescRet);

        [DllImport("DarumaFrameWork.dll")]
        public static extern int eAguardarRecepcao_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eAuditar_Daruma(string cAuditoria, int iFlag);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eAuditar(string pszAuditoria, int iFlag);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eCancelaComunicacao_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eDefinirProduto(string pszProduto);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eDefinirModoRegistro_Daruma(int intiTipo);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eVerificarVersaoDLL_Daruma(StringBuilder pszRet);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eVerificarVersaoDLL_Daruma(string pszRet);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regLogin_Daruma(string pszPDV);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regLogin(string pszPDV);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regRetornaValorChave_DarumaFramework(string pszProduto, string pszChave, string pszValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regRetornaValorChave(string pszProduto, string pszChave, string pszValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regAlteraValorChave_DarumaFramework(string pszProduto, string pszChave, string pszValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regAlteraValorChave(string pszProduto, string pszChave, string pszValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regAlterarValor_Daruma(string pszChave, string pszValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regAtoCotepe_Daruma(string pszChave, string pszValor);


        // --- Especiais - Fim ---


        //FUNCOES ECF 
        // Abertura de cupom fiscal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFAbrir_ECF_Daruma(string pszCPF, string pszNome, string pszEndereco);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFAbrirPadrao_ECF_Daruma();

        // Registro de item
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFVender_ECF_Daruma(string pszCargaTributaria, string pszQuantidade, string pszPrecoUnitario, string pszTipoDescAcresc, string pszValorDescAcresc, string pszCodigoItem, string pszUnidadeMedida, string pszDescricaoItem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFVenderSemDesc_ECF_Daruma(string pszCargaTributaria, string pszQuantidade, string pszPrecoUnitario, string pszCodigoItem, string pszUnidadeMedida, string pszDescricaoItem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFVenderResumido_ECF_Daruma(string pszCargaTributaria, string pszPrecoUnitario, string pszCodigoItem, string pszDescricaoItem);

        // Desconto ou acrescimo  em item de cupom fiscal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int fnCFLancarDescAcrescItem_ECF_Daruma(string pszNumItem, string pszTipoDescAcresc, string pszValorDescAcresc);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFLancarAcrescimoItem_ECF_Daruma(string pszNumItem, string pszTipoDescAcresc, string pszValorDescAcresc);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFLancarDescontoItem_ECF_Daruma(string pszNumItem, string pszTipoDescAcresc, string pszValorDescAcresc);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFLancarAcrescimoUltimoItem_ECF_Daruma(string pszTipoDescAcresc, string pszValorDescAcresc);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFLancarDescontoUltimoItem_ECF_Daruma(string pszTipoDescAcresc, string pszValorDescAcresc);

        // Cancelamento total de item em cupom fiscal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFCancelarItem_ECF_Daruma(string pszNumItem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFCancelarUltimoItem_ECF_Daruma();

        // Cancelamento parcial de item em cupom fiscal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFCancelarItemParcial_ECF_Daruma(string pszNumItem, string pszQuantidade);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFCancelarUltimoItemParcial_ECF_Daruma(string pszQuantidade);

        // Cancelamento de desconto em item
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFCancelarDescontoItem_ECF_Daruma(string pszNumItem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFCancelarDescontoUltimoItem_ECF_Daruma();

        // Cancelamento de acrescimo em item
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFCancelarAcrescimoItem_ECF_Daruma(string pszNumItem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFCancelarAcrescimoUltimoItem_ECF_Daruma();

        // Totalizacao de cupom fiscal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFTotalizarCupom_ECF_Daruma(string pszTipoDescAcresc, string pszValorDescAcresc);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFTotalizarCupomPadrao_ECF_Daruma();

        //Cancelamento de desconto e acrescimo em subtotal de cupom fiscal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFCancelarDescontoSubtotal_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFCancelarAcrescimoSubtotal_ECF_Daruma();

        //Descricao do meios de pagamento de cupom fiscal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFEfetuarPagamentoPadrao_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFEfetuarPagamentoFormatado_ECF_Daruma(string pszFormaPgto, string pszValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFEfetuarPagamento_ECF_Daruma(string pszFormaPgto, string pszValor, string pszInfoAdicional);

        //Saldo a Pagar
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rCFSaldoAPagar_ECF_Daruma(StringBuilder pszValor);

        //SubTotal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rCFSubTotal_ECF_Daruma(StringBuilder pszValor);

        //Encerramento de cupom fiscal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFEncerrarPadrao_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFEncerrarConfigMsg_ECF_Daruma(string pszMensagem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFEncerrar_ECF_Daruma(string pszCupomAdicional, string pszMensagem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFEncerrarResumido_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFEmitirCupomAdicional_ECF_Daruma();

        //Cancelamento de cupom fiscal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFCancelar_ECF_Daruma();

        //Status Cupom Fiscal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rCFVerificarStatus_ECF_Daruma(StringBuilder cStatusCF, ref int piStatusCF);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rCFVerificarStatusInt_ECF_Daruma(ref int iStatusCF);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rCFVerificarStatusStr_ECF_Daruma(StringBuilder cStatusCF);

        //Identificar consumidor radape do Cupom fiscal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFIdentificarConsumidor_ECF_Daruma(string pszNome, string pszEndereco, string pszDoc);

        //Cupom Mania
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rCMEfetuarCalculo_ECF_Daruma(StringBuilder pszISS, StringBuilder pszICMS);

        //Bilhete Passagem
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFBPAbrir_ECF_Daruma(string pszOrigem, string pszDestino, string pszUFDestino, string pszPercurso, string pszPrestadora, string pszPlataforma, string pszPoltrona, string pszModalidadetransp, string pszCategoriaTransp, string pszDataEmbarque, string pszRGPassageiro, string pszNomePassageiro, string pszEnderecoPassageiro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFBPVender_ECF_Daruma(string pszAliquota, string pszValor, string pszTipoDescAcresc, string pszValorDescAcresc, string pszDescricao);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int confCFBPProgramarUF_ECF_Daruma(string pszUF);

        //Download Memórias	
        //Espelho MFD 
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rEfetuarDownloadMFD_ECF_Daruma(string pszTipo, string pszInicial, string pszFinal, string pszNomeArquivo);

        //Espelho MFD 
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rGerarEspelhoMFD_ECF_Daruma(string pszTipo, string pszInicial, string pszFinal);

        [DllImport("DarumaFrameWork.dll")]
        public static extern int rEfetuarDownloadMF_ECF_Daruma(string pszNomeArquivo);

        [DllImport("DarumaFrameWork.dll")]
        public static extern int rEfetuarDownloadTDM_ECF_Daruma(string pszTipo, string pszInicial, string pszFinal, string pszNomeArquivo);

        // Relatorios PAF-ECF
        //Relatório PAF-ECF ON-line	
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rGerarRelatorio_ECF_Daruma(string pszRelatorio, string pszTipo, string pszInicial, string pszFinal);

        //Relatório PAF-ECF Off-line
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rGerarRelatorioOffline_ECF_Daruma(string szRelatorio, string szTipo, string szInicial, string szFinal, string szArquivo_MF, string szArquivo_MFD, string szArquivo_INF);

        //RSA - EAD PAF-ECF
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rAssinarRSA_ECF_Daruma(string pszPathArquivo, string pszChavePrivada, StringBuilder pszAssinaturaGerada);

        //MD5	
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rCalcularMD5_ECF_Daruma(string pszPathArquivo, StringBuilder pszMD5GeradoHex, StringBuilder pszMD5GeradoAscii);

        //Codigo de Barras
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iImprimirCodigoBarras_ECF_Daruma(string pszTipo, string pszLargura, string pszAltura, string pszImprTexto, string pszCodigo, string pszOrientacao, string pszTextoLivre);

        // --- ECF - Relatorio Gerencial - Inicio --- 
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iRGAbrir_ECF_Daruma(string pszNomeRG);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iRGAbrirIndice_ECF_Daruma(int iIndiceRG);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iRGAbrirPadrao_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iRGImprimirTexto_ECF_Daruma(string pszTexto);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iRGFechar_ECF_Daruma();
        // --- ECF - Relatorio Gerencial - Fim --- 

        // --- ECF - Comprovante de CD - Inicio --- 
        // Abertura de comprovante de credito e debito
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCCDAbrir_ECF_Daruma(string pszFormaPgto, string pszParcelas, string pszDocOrigem, string pszValor, string pszCPF, string pszNome, string pszEndereco);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCCDAbrirSimplificado_ECF_Daruma(string pszFormaPgto, string pszParcelas, string pszDocOrigem, string pszValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCCDAbrirPadrao_ECF_Daruma();

        // Impressao de texto no comprovante de credito e debito
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCCDImprimirTexto_ECF_Daruma(string pszTexto);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCCDImprimirArquivo_ECF_Daruma(string pszArqOrigem);

        // Fechamento de texto no comprovante de credito e debito
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCCDFechar_ECF_Daruma();

        // Estorno de comprovante de credito e debito
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCCDEstornarPadrao_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCCDEstornar_ECF_Daruma(string pszCOO, string pszCPF, string pszNome, string pszEndereco);

        //Segunda via de comprovante de crédito e débito
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCCDSegundaVia_ECF_Daruma();


        //Métodos para TEF
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iTEF_ImprimirResposta_ECF_Daruma(String szArquivo, Boolean bTravarTeclado);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iTEF_ImprimirRespostaCartao_ECF_Daruma(string szArquivo, Boolean bTravarTeclado, string szForma, string szValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iTEF_Fechar_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eTEF_EsperarArquivo_ECF_Daruma(String szArquivo, int iTempo, Boolean bTravar);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eTEF_TravarTeclado_ECF_Daruma(Boolean bTravar);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eTEF_SetarFoco_ECF_Daruma(String szNomeTela);

        // --- ECF - Leitura Memoria Fiscal - Inicio --- 
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iMFLerSerial_ECF_Daruma(string pszInicial, string pszFinal);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iMFLer_ECF_Daruma(string pszInicial, string pszFinal);

        // --- ECF - Comprovante não fiscal - Inicio --- 
        // Abertura de comprovante nao fiscal
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFAbrir_ECF_Daruma(string pszCPF, string pszNome, string pszEndereco);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFAbrirPadrao_ECF_Daruma();

        // Recebimento de itens
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFReceber_ECF_Daruma(string pszIndice, string pszValor, string pszTipoDescAcresc, string pszValorDescAcresc);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFReceberSemDesc_ECF_Daruma(string pszIndice, string pszValor);

        //Cancelamento de item
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFCancelarItem_ECF_Daruma(string pszNumItem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFCancelarUltimoItem_ECF_Daruma();

        //Cancelamento de acrescimo em item
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFCancelarAcrescimoItem_ECF_Daruma(string pszNumItem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFCancelarAcrescimoUltimoItem_ECF_Daruma();

        // Cancelamento de desconto em item
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFCancelarDescontoItem_ECF_Daruma(string pszNumItem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFCancelarDescUltimoItem_ECF_Daruma();

        // Totalizacao de CNF
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFTotalizarComprovante_ECF_Daruma(string pszTipoDescAcresc, string pszValorDescAcresc);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFTotalizarComprovantePadrao_ECF_Daruma();

        // Cancelamento de desconto e acrescimo em subtotal de CNF
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFCancelarAcrescimoSubtotal_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFCancelarDescontoSubtotal_ECF_Daruma();


        // Descricao do meios de pagamento de CNF
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFEfetuarPagamento_ECF_Daruma(string pszFormaPgto, string pszValor, string pszInfoAdicional);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFEfetuarPagamentoFormatado_ECF_Daruma(string pszFormaPgto, string pszValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFEfetuarPagamentoPadrao_ECF_Daruma();

        // Encerramento de CNF
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFEncerrar_ECF_Daruma(string pszMensagem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFEncerrarPadrao_ECF_Daruma();

        //Cancelamento de CNF
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCNFCancelar_ECF_Daruma();

        // --- ECF - Comprovante não fiscal - Fim ---

        // --- ECF - Funcoes Gerais - Inicio --- 
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iEjetarCheque_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iEstornarPagamento_ECF_Daruma(string pszFormaPgtoEstornado, string pszFormaPgtoEfetivado, string pszValor, string pszInfoAdicional);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eAcionarGuilhotina_ECF_Daruma(string pszTipoCorte);

        // Leitura X
        [DllImport("DarumaFrameWork.dll")]
        public static extern int fnLeituraX_ECF_Daruma(int iTipo, string pszCaminho);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iLeituraX_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rLeituraX_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rLeituraXCustomizada_ECF_Daruma(string pszCaminho);

        // Sangria
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iSangriaPadrao_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iSangria_ECF_Daruma(string pszValor, string pszMensagem);

        // Suprimento
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iSuprimentoPadrao_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iSuprimento_ECF_Daruma(string pszValor, string pszMensagem);

        // Reducao Z
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iReducaoZ_ECF_Daruma(string NamelessParameter1, string NamelessParameter2);

        // Acionamento da Gaveta do ECF
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eAbrirGaveta_ECF_Daruma();

        // Programação do ECF
        [DllImport("DarumaFrameWork.dll")]
        public static extern int confCadastrarPadrao_ECF_Daruma(string pszCadastrar, string pszValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int confCadastrar_ECF_Daruma(string pszCadastrar, string pszValor, string pszSeparador);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int confHabilitarHorarioVerao_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int confDesabilitarHorarioVerao_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int confProgramarOperador_ECF_Daruma(string pszValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int confProgramarIDLoja_ECF_Daruma(string pszValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int confProgramarAvancoPapel_ECF_Daruma(string pszSepEntreLinhas, string pszSepEntreDoc, string pszLinhasGuilhotina, string pszGuilhotina, string pszImpClicheAntecipada);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int confHabilitarModoPreVenda_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int confDesabilitarModoPreVenda_ECF_Daruma();


        // Funcoes - Retorno
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rLerAliquotas_ECF_Daruma(StringBuilder cAliquotas);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rCodigoModeloFiscal_ECF_Daruma(StringBuilder cValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rLerMeiosPagto_ECF_Daruma(StringBuilder pszRelatorios);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rLerRG_ECF_Daruma(StringBuilder pszRelatorios);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rLerDecimais_ECF_Daruma(StringBuilder pszDecimalQtde, StringBuilder pszDecimalValor, ref int piDecimalQtde, ref int piDecimalValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rLerDecimaisInt_ECF_Daruma(ref int piDecimalQtde, ref int piDecimalValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rLerDecimaisStr_ECF_Daruma(StringBuilder pszDecimalQtde, StringBuilder pszDecimalValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rDataHoraImpressora_ECF_Daruma(StringBuilder pszData, StringBuilder pszHora);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rVerificarImpressoraLigada_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusImpressora_ECF_Daruma(StringBuilder pszStatus);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusImpressoraStr_ECF_Daruma(StringBuilder pszStatus);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusImpressoraInt_ECF_Daruma(ref int piStatusEcf);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rInfoEstentida_ECF_Daruma(int NamelessParameter1, [MarshalAs(UnmanagedType.VBByRefStr)]  ref string NamelessParameter2);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rInfoEstentida1_ECF_Daruma(StringBuilder cInfoEx);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rInfoEstentida2_ECF_Daruma(StringBuilder cInfoEx);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rInfoEstentida3_ECF_Daruma(StringBuilder cInfoEx);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rInfoEstentida4_ECF_Daruma(StringBuilder cInfoEx);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rInfoEstentida5_ECF_Daruma(StringBuilder cInfoEx);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rVerificarReducaoZ_ECF_Daruma(StringBuilder zPendente);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusUltimoCmd_ECF_Daruma(StringBuilder pszErro, StringBuilder pszAviso, ref int piErro, ref int piAviso);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusUltimoCmdInt_ECF_Daruma(ref int piErro, ref int piAviso);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rUltimoCMDEnviado_ECF_Daruma(StringBuilder ultimoCMD);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rTipoUltimoDocumentoStr_ECF_Daruma(StringBuilder ultimoDOC);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rTipoUltimoDocumentoInt_ECF_Daruma(StringBuilder ultimoDOC);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iRelatorioConfiguracao_ECF_Daruma();

        [DllImport("DarumaFrameWork.dll")]
        public static extern int rConsultaStatusImpressoraInt_ECF_Daruma(int iIndice, ref int IStatus);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rConsultaStatusImpressoraStr_ECF_Daruma(int iIndice, StringBuilder StrStatus);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusImpressoraBinario_ECF_Daruma(StringBuilder Status);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rRetornarInformacaoSeparador_ECF_Daruma(string pszIndice, string pszVSignificativo, StringBuilder pszRetornar);



        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusUltimoCmdStr_ECF_Daruma(StringBuilder cErro, StringBuilder cAviso);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rRetornarInformacao_ECF_Daruma(string pszIndice, StringBuilder pszRetornar);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rRetornarNumeroSerieCodificado_ECF_Daruma(StringBuilder pszSerialCriptografado);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rVerificarNumeroSerieCodificado_ECF_Daruma(string pszSerialCriptografado);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rCarregarNumeroSerie_ECF_Daruma(StringBuilder pszSerial);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rRetornarDadosReducaoZ_ECF_Daruma(StringBuilder pszDados);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rRegistrarNumeroSerie_ECF_Daruma();

        [DllImport("DarumaFrameWork.dll")]
        public static extern int rRetornarGTCodificado_ECF_Daruma(StringBuilder pszGTCodificado);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rVerificarGTCodificado_ECF_Daruma(string pszGTCodificado);

        // --- ECF - Funcoes Gerais - Fim ---

        // --- ECF - Especiais - Inicio --- 

        [DllImport("DarumaFrameWork.dll")]
        public static extern int eAguardarCompactacao_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eBuscarPortaVelocidade_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eEnviarComando_ECF_Daruma(string cComando, int iTamanhoComando, int iType);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eRetornarAviso_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eRetornarErro_ECF_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eRetornarPortasCOM_ECF_Daruma(StringBuilder PortasCOM);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eRSAAssinarArquivo_ECF_Daruma(string arquivo, string chave);

        // --- ECF - Especiais - Fim --- 


        // --- ECF - Registro - Inicio --- 
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCCDDocOrigem_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCCDFormaPgto_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCCDLinhasTEF_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCCDParcelas_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCCDValor_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCFFormaPgto_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCFMensagemPromocional_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCFQuantidade_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCFTamanhoMinimoDescricao_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCFTipoDescAcresc_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCFUnidadeMedida_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCFValorDescAcresc_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCFCupomAdicional_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCFCupomMania(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCFCupomAdicionalDllConfig_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCFCupomAdicionalDllTitulo_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regChequeXLinha1_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regChequeXLinha2_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regChequeXLinha3_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regChequeYLinha1_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regChequeYLinha2_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regChequeYLinha3_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regCompatStatusFuncao_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regMaxFechamentoAutomatico_ECF_Daruma(string pszParametro);

        [DllImport("DarumaFrameWork.dll")]
        public static extern int regECFAguardarImpressao_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regECFArquivoLeituraX_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regECFAuditoria_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regECFCaracterSeparador_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regECFMaxFechamentoAutomatico_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regECFReceberAvisoEmArquivo_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regECFReceberErroEmArquivo_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regECFReceberInfoEstendida_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regECFReceberInfoEstendidaEmArquivo_ECF_Daruma(string pszParametro);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regAtocotepe_ECF_Daruma(string pszParametro1, string pszParametro2);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eDefinirModoRegistro_Daruma(string pszParametro);


        // --- ECF - Registro - Fim --- 

        #endregion
    }
}