using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AuctionAPI.AuctionService;

namespace AuctionAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //보안티켓 생성
            //AuthenticationTicket oldTicket = new AuthenticationTicket();
            //oldTicket.Value = string.Empty;

            EncryptedTicketHeader ticket = new EncryptedTicketHeader();
            ticket.Value = "d7brLk7Xo1REImXesMrfHZkJOixYwmBS4HPIFR1G8hklLjABICJpZHRNdV/0izl4r6rf47QkU7xB1xYof+g1+S3a+g//+OzvoMOMv6PVOdGCg8fo/X4S3htFh5CVLW7rQgpLr/HpZ+v6YJqoP6QC6z6LltmnTtvGKiDKcyCvknUiGTBXZ4bUcpq4aOqzJL4TDoFv5cogIth4pQQIXjZyRxY=";
            
            //검색 파라미터 생성
            GetSearchResultsBest100RequestT request = new GetSearchResultsBest100RequestT();
            //request.Query = txtSearch.Text;

            //Page 설정
            PaginationT pageNation = new PaginationT();
            pageNation.PageIndex = 0;
            pageNation.PageSize = 1;

            request.Pagination = pageNation;

            //API호출
            GetSearchResultsResponseT response = new AuctionServiceSoapClient().GetSearchResultsBest100(null, ref ticket, request);
        }
    }
}
 