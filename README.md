# Tweet My Likes - an Azure function that randomly shares tweets you've liked in the past 

The idea with this function is that you can put your twitter account on auto pilot. It will take a variable number of tweets you've liked in the past, select one at random, and then share it as a new tweet. This function simply uses a timer trigger to tweet a random "like" every 4 hours.

You can setup this function and hit "like" on new and interesting tweets every day. You'll randomly tweet them out later on autopilot. Here's the basic steps to make use of this code. It assumes you already have a function app built and you know your way around Azure functions a bit.

1. You'll need to create your own twitter app at https://apps.twitter.com/
2. Make sure your twitter app has read/write access to your twitter account
3. Take the values for the consumer key, consumer secret, access token, and access token secret from your twitter app and add them as "App Setting" key/value pairs within the Application Settings of your function app, like so:

![alt text](https://cloud.githubusercontent.com/assets/5126491/26689481/9e4219a4-46aa-11e7-888a-355a0a6cb9b1.png "README Image")

4. Update run.csx with your own twitter screen name on line 9
5. Update the cron schedule in function.json if you want to change how ofter your function runs

Note: by default, this function will take your last 20 likes and pick one at random to tweet when the function runs. You can change this in the run.csx file.
