using Conferen_Visit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conferen_Visit.Abstract
{
    public interface IGuestRepository
    {
        IEnumerable<GuestResponse> Guest { get; }
        void SaveGuest(GuestResponse guest);
        GuestResponse DeleteGuest(int guestId);
    }
}