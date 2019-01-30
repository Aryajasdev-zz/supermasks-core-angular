namespace supermasks.biz
{
    public class realrequest
    {
        public string MERCHANT_ID { get; set; }
        public string ACCOUNT { get; set; }
        public string ORDER_ID { get; set; }
        public string AMOUNT { get; set; }
        public string CURRENCY { get; set; }
        public string TIMESTAMP { get; set; }
        public string SHA1HASH { get; set; }
        public string AUTO_SETTLE_FLAG { get; set; }
        public string COMMENT1 { get; set; }
        public string COMMENT2 { get; set; }
        public string RETURN_TSS { get; set; }
        public string SHIPPING_CODE { get; set; }
        public string SHIPPING_CO { get; set; }
        public string BILLING_CODE { get; set; }
        public string BILLING_CO { get; set; }
        public string CUST_NUM { get; set; }
        public string VAR_REF { get; set; }
        public string PROD_ID { get; set; }
        public string HPP_LANG { get; set; }
        public string CARD_PAYMENT_BUTTON { get; set; }
        public string CARD_STORAGE_ENABLE { get; set; }
        public string OFFER_SAVE_CARD { get; set; }
        public string PAYER_REF { get; set; }
        public string PMT_REF { get; set; }
        public string PAYER_EXIST { get; set; }
        public string VALIDATE_CARD_ONLY { get; set; }
        public string DCC_ENABLE { get; set; }  
        public string HPP_SELECT_STORED_CARD { get; set; }
    }

    public class TSS
    {
        public string TSS_2 { get; set; }
        public string TSS_1 { get; set; }
    }

    public class realresponse
    {
        public string MERCHANT_ID { get; set; }
        public string ACCOUNT { get; set; }
        public string ORDER_ID { get; set; }
        public string AMOUNT { get; set; }
        public string AUTHCODE { get; set; }
        public string TIMESTAMP { get; set; }
        public string SHA1HASH { get; set; }
        public string RESULT { get; set; }
        public string MESSAGE { get; set; }
        public string CVNRESULT { get; set; }
        public string PASREF { get; set; }
        public string BATCHID { get; set; }
        public string ECI { get; set; }
        public string CAVV { get; set; }
        public string XID { get; set; }
        public string COMMENT1 { get; set; }
        public string COMMENT2 { get; set; }
        public TSS TSS { get; set; }
        public string AVSADDRESSRESULT { get; set; }
        public string AVSPOSTCODERESULT { get; set; }
    }
}
