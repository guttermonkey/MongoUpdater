MongoUpdater
============

I'm beginning to play with updating my MongoDB collections using C# based Windows Services and tooled up this
small application during testing in order to figure out the best way to do the updates I need to.  This iteration
is not LINQ based, rather it uses the native Mongo driver capabilities to update a single key/value pair for a
single entry in a collection using command-line arguments.

You will need to download and install the MongoDB C# driver, which can be found here:
https://github.com/mongodb/mongo-csharp-driver/downloads

Usage: 'MongoUpdater.exe <server> <database> <collection> <search key> <value for search key> <update key> <update value>'