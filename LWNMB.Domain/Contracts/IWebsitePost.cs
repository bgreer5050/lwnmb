using System;
namespace LWNMB.Domain.Contracts
{
  public  interface IWebsitePost
    {
        string FrontPage { get; set; }
        int Id { get; set; }
        DateTime PublishEndDate { get; set; }
        DateTime PublishStartDate { get; set; }
        Section Section { get; set; }
        string Title { get; set; }
    }
}
