// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Variable Declerations
string companyName;
string foundersName;
int currentVersion;
char marketCapRanking;
string ticker;
bool isDecentralized;
double totalSupply;
decimal currentPrice;

//Variable Initalizations
companyName = "Ethereum";
foundersName = "Vitalik Buterin";
currentVersion = 2;
marketCapRanking = '2';
ticker = "Eth";
isDecentralized = true;
totalSupply = 120_460_784;
currentPrice = 1737.97m;

Console.WriteLine($"{companyName} was co-founded by {foundersName} in 2014. " +
    $"It's currently transitioning to version {currentVersion}.It's current market cap ranking is {marketCapRanking}." +
    $"The trading symbol is {ticker}. Is it decentralized? {isDecentralized}" +
    $"The total supply is {totalSupply} with a current price of {currentPrice}.");

Console.ReadLine();