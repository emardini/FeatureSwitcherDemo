# FeatureSwitcherDemo
To demonstrate how to use featureswitcher to enable/disable features in a ASP.NET MVC application

1. Add the packages featureswitcher and featureswitcher.configuration
2. Add configuration entries in the web.config to control the toggle
2. Add a class to hold the feature toggle => AboutMethod
3. Add the code that uses the feature toggle => HomeController.About
4. Add class to bootstrap the configuration => App_Start.FeaturesConfig
4. Bootstrap the configuration  => Global.asax => Application_Start => add FeauresConfig.Start()
5. Test turning on/off the toggle

It is possible to improve the way we use the toggle implementing filters with attributes or handlers
The toggle can also be applied in the site map

Tutorials
http://slides.com/mexx/featureswitcher#/
http://www.javacodegeeks.com/2014/08/feature-toggles-feature-switches-or-feature-flags-vs-feature-branches.html
http://www.slideshare.net/jug-berlin-brandenburg/feature-toggles-on-steroids
https://github.com/mexx/FeatureSwitcher



