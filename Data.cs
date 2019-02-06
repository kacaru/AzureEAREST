using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_EA_Cost
{
    class Data
    {
        //All values are not set to their correct type.
        public string serviceName { get; set; } //Storage,
        public string serviceTier { get; set; }//Premium Page Blobs,
        public string location { get; set; }//US West,
        public string chargesBilledSeparately { get; set; }//false,
        public string partNumber { get; set; }//ABC-12345,
        public string resourceGuid { get; set; }//00000000-0000-0000-0000-000000000000,
        public string offerId { get; set; }//MS-AZR-0003P,
        public double cost { get; set; }//1,
        public string accountId { get; set; }//123456,
        public string productId { get; set; }//1234,
        public string resourceLocationId { get; set; }//12,
        public string consumedServiceId { get; set; }//1,
        public string departmentId { get; set; }//3456,
        public string accountOwnerEmail { get; set; }//account@live.com,
        public string accountName { get; set; }//Account Name,
        public string serviceAdministratorId { get; set; }//123,
        public string subscriptionId { get; set; }//0000000,
        public string subscriptionGuid { get; set; }//00000000-0000-0000-0000-000000000000,
        public string subscriptionName { get; set; }//Subscription Name,
        public string date { get; set; }//2018-08-01T00;//00;//00,
        public string product { get; set; }//Locally Redundant Storage Premium Storage - Page Blob/P10 - US West,
        public string meterId { get; set; }//00000000-0000-0000-0000-000000000000,
        public string meterCategory { get; set; }//Storage,
        public string meterSubCategory { get; set; }//Locally Redundant,
        public string meterRegion { get; set; }//California,
        public string meterName { get; set; }//Premium Storage - Page Blob/P10 (Units),
        public string consumedQuantity { get; set; }//1
        public string resourceRate { get; set; }//1,
        public string resourceLocation { get; set; }//uswest,
        public string consumedService { get; set; }//Microsoft.Compute,
        public string instanceId { get; set; }//Id,
        public string serviceInfo1 { get; set; }//string,
        public string serviceInfo2 { get; set; }//string,
        public string additionalInfo { get; set; }//string,
        public string tags { get; set; }//string,
        public string storeServiceIdentifier { get; set; }//string,
        public string departmentName { get; set; }//Department Name,
        public string costCenter { get; set; }//1234,
        public string unitOfMeasure { get; set; }//Units,
        public string resourceGroup { get; set; }//ResourceGroup

    }
}
