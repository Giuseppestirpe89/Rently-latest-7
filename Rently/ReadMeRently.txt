
Hi Vikas for the purpose of this app please use

admin@rently.com Pasw = Admin1234!  so you will have full access to the app like adding customers, adding movies and rent movie,
 and seeing the difference between tabs by logging as an admin or a guest. for example if you log as an admin you will see tabs as movie,
 customers, new rental etc. go to https://localhost:44300/Customers/Details/1 to have a look at the details page as well
 or https://localhost:44300/Movies/Details/2 for the movie one.
 
use   guest@rently.com Psw = Guest1234! to have only read only view of the app. 
There is also a Facebok login and Google login but it works only with my account
check Startup.Auth.cs



as explain i couldnt migrate all the db to azure at http://rently2016.azurewebsites.net/. so if
you are tring to login you will get an error  Unable to complete operation. 
The supplied SqlConnection does not specify an initial catalog or AttachDBFileName, even though the conenction string on the web.config is from
azure. but locally everything is working fine,
i also tried the seed method with no luck. 


when you go to the rental form and you search for a customer thansk t typeahed if you type just the first 3 letters
of the name ajax call will show you the name of the customer looked. same for the movies. once the rental is submit
a bootbox allert wil be shown on top of the screen for confirmation or if a problem occured.


There is an example of caching too. if you go on HomeControllers I used  [OutputCache(Duration = 50)] seconds. I dont need to cache that page
but it was just an example og showing output caching for a page.

For any other info you might need please contact me at giuseppestirpe89@gmail.com 

Thanks for your lecturers Regards
Giuseppe x13132181