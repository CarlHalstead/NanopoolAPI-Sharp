## What is this?
This is a C# wrapper for the Cryptocurrency mining platform, Nanopool. Its wraps the web API into an easy to use package.

## What cant this do?
As of this moment (9th September) it only uses the Miner section of the API which is used to get access about a user and their miners. However, I would like to continue to develop it and implement the entire API. As for the Miner section of the API this can retrive about 95% of the calls.

## How does it work?
It simply constructs the URL using the enum that you pass into the method along with your cryptocurrency address. It then downloads the JSON from the URL and parses it into a C# class which is returned and able to be accessed by the user.

## How do I install it?
* Through the Nuget package manager - Simply search for Nanopool or run:
```
Install-Package NanopoolAPI -Version 0.9.0
```
* Alternatively, visiting the [nuget](https://www.nuget.org/packages/NanopoolAPI/) page and downloading the package manually

Within your scripts you can then add 3 using statements:
```
using NanopoolAPI_Sharp;
using NanopoolAPI_Sharp.Data;
using NanopoolAPI_Sharp.Helpers;
```

## How do I make my first call?
After including the using statements in the previous question, you now want to create a new 'EthClient'.
```
EthClient client = new EthClient("YourEthAddress");
```

Now, you can use the method SendRequest like so:
```
var result = await client.SendRequest<GeneralInfo>(Requests.RequestType.User);
Console.WriteLine(result.info.balance);
```
In that example, it will print the Eth balance of your account to the console
It is <b>very important</b> that you match the correct class with the type of call you are making.

For example, calling SendRequest with the Requests.RequestType.User value will return a GeneralInfo class, whereas a value of Requests.RequestType.AccountExist will return a class of AccountExists.

## How do I know which class I should supply?
I commented everything so you should be able to hover over the enum and it will say something along the lines of:
```
Pair with the 'AccountExists' class
```
Which should give you an indication of what to use.

## Are there any dependancies?
Yes! Make sure you have Newtonsoft JSON installed. The latest version should be fine and can be installed however you want.
