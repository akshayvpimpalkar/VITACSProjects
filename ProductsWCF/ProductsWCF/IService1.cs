﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProductsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProdDervice" in both code and config file together.
    [ServiceContract]
    public interface IProdService
    {

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml,
                                   BodyStyle = WebMessageBodyStyle.Bare,
                                   UriTemplate = "GetProductList/")]
        List<Product> getProducts();

       
    }

}
