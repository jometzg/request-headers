# Request Headers

A small demo of a web service that returns a JSON array of the HTTP headers that have been sent to it.

Allows for the debugging of proxy-related issues outbound from a calling service.

```
curl --header "Accept: text/javascript" --header "Mixed_Case: Mixed_Case" --header "ALL_UPPER: UPPER" --header "all-lower: lower" -k  https://deployed-URL/weatherforecast

```
