var resemble = require('../resemble.js');
var azure = require('azure-storage');

blobSvc.listBlobsSegmented('photospeoplost', null, function (error, result, response) {
    if (!error) {
        console.log(result.entries);
    }
});

function searchPeople(fileData) {

    var blobSvc = azure.createBlobServiceAnonymous('https://sampaellastorage.blob.core.windows.net/');
    blobSvc.listBlobsSegmented('photospeoplost', null, function (error, result, response) {
        if (!error) {
            console.log(result.entries);
            //contains the entries
            // If not all blobs were returned, result.continuationToken has the continuation token.
            //resemble.outputSettings({
            //    errorColor: {
            //        red: 155,
            //        green: 100,
            //        blue: 155
            //    },
            //    errorType: 'movement',
            //    transparency: 0.6
            //});

            //resemble(result).compareTo(fileData)
            //  //.ignoreAntialiasing()
            //  //.ignoreColors()
            //  .onComplete(function (data) {
            //      console.log(data);
            //      data.getDiffImage().pack().pipe(fs.createWriteStream('diff.png'));
            //  });
        }
    });
}

//http.createServer(app).listen(app.get('port'), function () {
//    console.log('Express server listening on port ' + app.get('port'));
//});
