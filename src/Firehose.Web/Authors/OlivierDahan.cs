using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class OlivierDahan : IAmAMicrosoftMVP
    {
        public string FirstName => "Olivier";
        public string LastName => "Dahan";
        public string ShortBioOrTagLine => "Consultant Architecte Xamarin C# XAML MVVM";
        public string StateOrRegion => "France";
        public string EmailAddress => "odahan@e-naxos.com";
        public string TwitterHandle => "odenaxos";
        public string GravatarHash => "f8a39142356ff7c473401c2408c353f8";
        public string GitHubHandle => "odahan";
        public GeoPosition Position => new GeoPosition(47.99729, 2.736291);

        public Uri WebSite => new Uri("https://e-naxos.com/blog");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.e-naxos.com/blog/syndication.axd"); } }
        public string FeedLanguageCode => "fr";
    }
}
