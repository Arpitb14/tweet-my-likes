using System;
using System.Configuration;
using TweetSharp;

static string _consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
static string _consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
static string _accessToken = ConfigurationManager.AppSettings["AccessToken"];
static string _accessTokenSecret = ConfigurationManager.AppSettings["AccessTokenSecret"];
static string _screenName = "<your twitter handle>";

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    var service = new TwitterService(_consumerKey, _consumerSecret);
    service.AuthenticateWith(_accessToken, _accessTokenSecret);
		
    var gettweet = service.ListFavoriteTweets(
        new ListFavoriteTweetsOptions { ScreenName = _screenName }
    );

    var rand = new Random();
    var tweetId = rand.Next(1, 21);

    var tweet = (from t in gettweet select t.Text).Take(20);
    var status = tweet.ToArray()[tweetId].ToString();

    var newTweet = service.SendTweet(
        new SendTweetOptions { Status = status }
    );
}
