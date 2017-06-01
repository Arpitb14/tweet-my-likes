using System;
using System.Configuration;
using TweetSharp;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    var _consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
    var _consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
    var _accessToken = ConfigurationManager.AppSettings["AccessToken"];
    var _accessTokenSecret = ConfigurationManager.AppSettings["AccessTokenSecret"];

    var service = new TwitterService(_consumerKey, _consumerSecret);
    service.AuthenticateWith(_accessToken, _accessTokenSecret);
		
    var gettweet = service.ListFavoriteTweets(
        new ListFavoriteTweetsOptions { ScreenName = "<your twitter handle>" }
    );

    var rand = new Random();
    var tweetId = rand.Next(0, 21);

    var tweet = (from t in gettweet select t.Text).Take(20);
    var status = tweet.ToArray()[tweetId].ToString();

    var newTweet = service.SendTweet(
        new SendTweetOptions { Status = status }
    );
}