# Request Headers

A small demo of a web service that returns a JSON array of the HTTP headers that have been sent to it.

Allows for the debugging of proxy-related issues outbound from a calling service.

```
curl --header "Accept: text/javascript" --header "Mixed_Case: Mixed_Case" --header "ALL_UPPER: UPPER" --header "all-lower: lower" -k  https://deployed-URL/weatherforecast

```
{"Accept":["text/javascript"],"Host":["jjtargetcontainer.azurewebsites.net"],"User-Agent":["curl/7.68.0"],"Max-Forwards":["10"],"Mixed_Case":["Mixed_Case"],"ALL_UPPER":["UPPER"],"all-lower":["lower"],"X-ARR-LOG-ID":["baa3b00f-7e22-4635-8f7a-3dd310d26c4e"],"CLIENT-IP":["212.159.20.110:62294"],"X-Client-IP":["212.159.20.110"],"DISGUISED-HOST":["jjtargetcontainer.azurewebsites.net"],"X-SITE-DEPLOYMENT-ID":["jjtargetcontainer"],"WAS-DEFAULT-HOSTNAME":["jjtargetcontainer.azurewebsites.net"],"X-Forwarded-Proto":["https"],"X-AppService-Proto":["https"],"X-ARR-SSL":["2048|256|CN=Microsoft Azure TLS Issuing CA 01, O=Microsoft Corporation, C=US|CN=*.azurewebsites.net, O=Microsoft Corporation, L=Redmond, S=WA, C=US"],"X-Forwarded-TlsVersion":["1.2"],"X-Forwarded-For":["212.159.20.110:62294"],"X-Original-URL":["/weatherforecast"],"X-WAWS-Unencoded-URL":["/weatherforecast"],"X-Client-Port":["62294"]}
