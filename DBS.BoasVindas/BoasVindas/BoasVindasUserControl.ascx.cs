/* 
                          Desenvolvido por DBS IT Services
                         http://www.dbsitservices.com.br
                                     
           Copyright 2011 DBS IT Services © Todos os direitos reservados 

 Este aquivo contém código fonte de aplicativo desenvolvido pela DBS IT Services. 
 É expressamente proibida a alteração, distribuição ou venda desses arquivos sem 
 aprovação  formal da DBS IT Services e do cliente contratante desse serviço sob
 proteção da legislação vigente.
 
*/

using System;
using System.Web.UI;
using Microsoft.SharePoint;

namespace DBS.BoasVindas.BoasVindas
{
    public partial class BoasVindasUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var horario = DateTime.Now.Hour;

            switch (horario)
            {
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    lblSaudacao.Text = "Boa tarde,";
                    break;
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                    lblSaudacao.Text = "Boa noite,";
                    break;
                default:
                    lblSaudacao.Text = "Bom dia,";
                    break;
            }

            var user = SPContext.Current.Web.CurrentUser.Name;
            lblUsuario.Text = (user.Contains(@"\")) ? user.Split('\\')[1] : user;
        }
    }
}
