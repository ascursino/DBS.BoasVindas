/* 
                          Desenvolvido por DBS IT Services
                         http://www.dbsitservices.com.br
                                     
           Copyright 2011 DBS IT Services © Todos os direitos reservados 

 Este aquivo contém código fonte de aplicativo desenvolvido pela DBS IT Services. 
 É expressamente proibida a alteração, distribuição ou venda desses arquivos sem 
 aprovação  formal da DBS IT Services e do cliente contratante desse serviço sob
 proteção da legislação vigente.
 
*/

using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;

namespace DBS.BoasVindas.BoasVindas
{
    [ToolboxItemAttribute(false)]
    public class BoasVindas : WebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/DBS.BoasVindas/BoasVindas/BoasVindasUserControl.ascx";

        protected override void CreateChildControls()
        {
            Control control = Page.LoadControl(_ascxPath);
            Controls.Add(control);
        }
    }
}
