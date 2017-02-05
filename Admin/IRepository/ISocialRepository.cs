using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.IRepository
{
    public interface ISocialRepository
    {
        SocialInformation IsAvailable(string UserId);
        void UpdateInformation(SocialInformation model);
    }
}