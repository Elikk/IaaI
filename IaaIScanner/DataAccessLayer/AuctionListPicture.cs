//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuctionListPicture
    {
        public int AuctionListPictureID { get; set; }
        public int AuctionID { get; set; }
        public int AuctionListItemNumber { get; set; }
        public byte[] Picture { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
    }
}