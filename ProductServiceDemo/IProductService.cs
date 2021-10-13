using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProductServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {

        [OperationContract]
        void AddProduct(ProductContract productContract);
        [OperationContract]
        List<ProductContract> GetProducts();
        [OperationContract]
        ProductContract GetProduct(int ProductId);
        [OperationContract]
        void UpdateProduct(ProductContract productContract);

        [OperationContract]
        void DeleteProduct(int productId);
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ProductServiceDemo.ContractType".
    [DataContract]
    public class ProductContract
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public string ImageUrl { get; set; }
    }
}
