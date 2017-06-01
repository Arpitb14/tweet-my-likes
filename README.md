# tweet-my-likes

The idea with this function is that you can put your twitter account on auto pilot. It will take a variable number of tweets you've liked in the past, select one at random, and then share it as a new tweet. This function simply uses a timer trigger to tweet a random like every 4 hours.

1. You'll need to create your own twitter app at https://apps.twitter.com/
2. Make sure your twitter app has read/write access to your twitter account
3. Take the values for the consumer key, access token, and access token secret from your twitter app and add them as "App Setting" key/value pairs within the Application Settings of your function app.
4. Update run.csx with your own twitter screen name on line 16
5. Update the cron schedule in function.json if you want to change how ofter your function runs
