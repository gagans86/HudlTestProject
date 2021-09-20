# HudlTestProject
To run these scenarios, you need to do following steps: 

1) Download Selenium Grid jar and go to open command console and go to path where Selenium Grid jar 

2) Run following commands in different commands console

to set up node : java -jar selenium-server-standalone-3.141.59.jar -role node -hub http://192.168.1.47:4444:4444/grid/register -browser "browserName=chrome,max Instances=3" -browser "browserName=chrome,maxInstances=3" -browser "browserName=safari,maxInstances=1"

pleae use url local IP address


to setup  hub : java -jar selenium-server-standalone-3.141.59.jar -role hub


3) Open the class TestInitializeHook in Base folder

4) _parallelConfig.Driver = new RemoteWebDriver(new Uri("http://192.168.1.47:4444/wd/hub"), driverOptions.ToCapabilities());

5) Change the url address to your localhost i.e http://{your IP address}.com:4444/wd/hub or your machine ip.

Java is must, please install JAVA

