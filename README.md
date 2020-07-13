# SpaceX

:rocket: ASP.NET Core app which aims to utilize data from the SpaceX Rest API.

**[Click](https://github.com/peterstoyanov/SpaceX/blob/master/SpaceX/SpaceX.Client/wwwroot/readme/Thaicom%206.pdf) to see an example of a PDF generated by the application.**

**[Click](https://vimeo.com/437704263) to see a video demonstration of the site.**

**Introduction**
![100x100](SpaceX/SpaceX.Client/wwwroot/readme/1.jpg)

**Official Photos**
![100x100](SpaceX/SpaceX.Client/wwwroot/readme/2.jpg)

**Launch Plans**
![100x100](SpaceX/SpaceX.Client/wwwroot/readme/3.jpg)

**Elon Musk**
![100x100](SpaceX/SpaceX.Client/wwwroot/readme/4.jpg)

The solution consists of three projects:

-   **SpaceX.Client**:   A Project with controllers that make endpoints available as well as files for the front-end components and settings
-   **SpaceX.Service**:  A class library referenced by the API that is responsible for making calls to the SpaceX REST API and deserializing the response. As well as the logic for generating a PDF document.
-   **SpaceX.Models**: Contains properties from JSON as classes from API.
## Setup

1.  Download and install the  [.NET Core SDK](https://www.microsoft.com/net/download)
    
2.  Clone this repo:  `$ git clone git@github.com:peterstoyanov/spacex.git`
    
4.  To run the project:  `$ dotnet run --project SpaceX.Client/SpaceX.Client.csproj`
   
## Used Technologies

- ASP.NET Core 3.1
- HTML
- CSS
- Bootstrap
- AJAX
- JavaScript
- DinkToPDF library

## Main advantages discovered

Logically distributed assemblies- services, web and models\
A convenient frontend design\
The majority of the code complies with the SOLID principles\
Search functionality using asynchronous requests with AJAX\
Using useful and convenient approach for converting data into PDF format \
The application has appropriate customer and server validations

### Available options:

> 1. Search by Mission Name through the search bar.
> 2. Order by a particular property by clicking on the section.
> 3. Click on an image from the Photos section to view it on a full screen.
> 4. Export and Save a copy of the PDF document by clicking the "Generate PDF" button.
