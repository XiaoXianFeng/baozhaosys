using RestSharp.Deserializers;

namespace Box
{

    public class OrderInfo
    {
        /**
        * 订单编码
        **/

        public string AgreementId
        {
            get;
            set;
        }

        public string OrderId
        {
            get;
            set;
        }

        //产品型号
        [DeserializeAs(Name = "DummyProductModel")]
        public string ProductModel
        {
            get;
            set;
        }

        //产品名称
        public string ProductName
        {
            get;
            set;
        }

        //产品描述
        public string ProductDesc
        {
            get;
            set;
        }

        //工单
        public string Workform
        {
            get;
            set;
        }
        
        //供应商
        public string FactoryName
        {
            get;
            set;
        }

        //古北编码
        public string MaterialCode
        {
            get;
            set;
        }
        //客户编码
        public string KehuCode
        {
            get;
            set;
        }
        //供应商
        public string VendorName
        {
            get;
            set;
        }
        //Ver
        public string ProductVerTag
        {
            get;
            set;
        }
        //批次号
        public string BatchNo
        {
            get;
            set;
        }

        //固件
        public string Firmware
        {
            get;
            set;
        }
        //标签颜色
        public string count
        {
            get;
            set;
        }
        //客户编码
        public string abandoncount
        {
            get;
            set;
        }
        //建滔编码
        public string platcode
        {
            get;
            set;
        }
        //备用选项1
        public string repaircount
        {
            get;
            set;
        }
        //备用选项2
        public string failcount
        {
            get;
            set;
        }
    }

    public class OrderResponse
    {
        public int Status
        {
            get;
            set;
        }

        public string Msg
        {
            get;
            set;
        }

        public OrderInfo OrderInfo
        {
            get;
            set;
        }
    }
}
