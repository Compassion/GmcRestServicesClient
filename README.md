# GmcRestServicesClient

.Net NuGet package that allows connecting to GMC's Mashery read-only REST web services. 

## Installation
1. Add Compassion Australia's [MyGet](https://www.myget.org/") feed as a NuGet package source in Visual Studio.
  - Source URL: https://www.myget.org/F/compassion
2. Install the package "GMC Rest Services Client".
3. Configure settings in App.config. The NuGet package will try to add two appSettings configuration keys. It may fail, though, in which case these will need to be added manually. The settings are:
  - "GmcRestServicesUrl" - This is the URL of the Marshery web service. Defaults to the test environment ("https://api2.compassion.com/iptest/ci/v1/").
  - "GmcRestServicesClientApiKey" - The Mashery API key to access the web service. Default is empty.

## Usage

To use, simply instantiate the GmcRestService class. All methods documented in the [Private REST Services documentation](http://developer.compassion.com/docs/read/private_cornerstone_test) on Mashery should be implemented. 

## Issues

 - A lot of data fields are typed as strings when they might be possible to be parsed as ints, decimals, etc. 
 - The REST service returns date/times with the GMC timezone in them. This has been stripped, because in most cases only the date is important. The client web service library we use, RestSharp, converts the dates to the local timezone, which sometimes meant dates changed days. 
