# Clean-Architecture-MediatR-And-CQRS-Template

<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
<!-- [![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url] -->



<!-- PROJECT LOGO -->
<br />
<p align="center">
<!--   <a href="https://github.com/othneildrew/Best-README-Template">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a> -->

  <h3 align="center">Clean-Architecture-MediatR-And-CQRS-Template</h3>

  <p align="center">
    An awesome Clean Architecture with MediatR and CQRS template to jumpstart your projects!
    <br />
    <a href="https://github.com/MahdiFaheem/Clean-Architecture-MediatR-And-CQRS-Template"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/MahdiFaheem/Clean-Architecture-MediatR-And-CQRS-Template">View Demo</a>
    ·
    <a href="https://github.com/MahdiFaheem/Clean-Architecture-MediatR-And-CQRS-Template/issues">Report Bug</a>
    ·
    <a href="https://github.com/MahdiFaheem/Clean-Architecture-MediatR-And-CQRS-Template/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

<!-- [![Product Name Screen Shot][product-screenshot]](https://example.com) -->

There are many great Clean Architechture templates available on GitHub, however, I didn't find one that really suit my needs so I created this enhanced one. I wanted to create a Clean Architechture template using MediatR and CQRS of an ASP.NET core web api so amazing that it'll be the last one you ever need -- I think this is it.

Here's why:
* Your time should be focused on creating something amazing. A project that solves a problem and helps others
* You shouldn't be doing the same tasks over and over like creating a project structure based on Clean Architechture using MediatR and CQRS of an ASP.NET core web api from scratch
* You should implement DRY principles to the rest of your life :smile:

Of course, no one template will serve all projects since your needs may be different. So I'll be adding more in the near future. You may also suggest changes by forking this repo and creating a pull request or opening an issue. Thanks to all the people have contributed to expanding this template!


### Built With

<!-- This section should list any major frameworks that you built your project using. Leave any add-ons/plugins for the acknowledgements section. Here are a few examples. -->
* [ASP.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet/3.1)
<!-- * [JQuery](https://jquery.com)
* [Laravel](https://laravel.com) -->



<!-- GETTING STARTED -->
## Getting Started

<!-- This is an example of how you may give instructions on setting up your project locally. -->
To get a local copy up and running follow these simple example steps.

### Prerequisites

<!-- This is an example of how to list things you need to use the software and how to install them. -->
1. ASP.Net Core 3.1 
  - You can download it within Visual Studio 2019 by accessing Visal Studio Installer which you can download and install from https://visualstudio.microsoft.com/downloads/
  - After installation run Visual Studio Installer, click install and from the options make sure ASP.NET and web development is selected. From there intall it by following the setup instructions.
2. Microsoft SQL Express 2018 
  - You can download and install the express version form the follwing link https://www.microsoft.com/en-us/sql-server/sql-server-downloads and follow the instruction given by the setup. 

<b>Development Tools: </b>
1. Visual Studio 2019
  - Visual Studio 2019 can be installed by first installing Visal Studio Installer which you can download and install from https://visualstudio.microsoft.com/downloads/
2. Microsoft SQL Server Management Studio 18.
  - Download and install from https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15
### Optional
Visual Studio Code.
 - Download and install from https://code.visualstudio.com/download
  
### Installation

Clone the repo
   ```sh
   git clone https://github.com/MahdiFaheem/Clean-Architecture-MediatR-And-CQRS-Template.git
   ```
   or you can click the button `Use This Template` on the repository page and then clone it from there.


<b>Process for running development environment:</b>
1.	Open the solution (.sln file) in Visual Studio 2019 IDE.
  - Wait for some time to let visual studio to download the required packages automatically. 
  - If not downloaded, head on to <code>Tools->NuGet Package Manager ->Manage NuGet package for solution</code> and download the required packages: <br>
o	Microsoft.EntityFrameworkCore<br>
o	Microsoft.EntityFrameworkCore.Tools <br>
o	Microsoft.EntityFrameworkCore.SQLServer <br>
o	AutoMapper.Extensions.Microsoft.DependencyInjection<br>
o	FluentValidation <br>
o	MediatR.Extensions.Microsoft.DependencyInjection<br>

2. Head on to appsettings.json in solution explorer and put your respective server name in the connection string inside <code>Server =  ;</code> area below. You can generally find it Microsoft SQL Server Management Studio 18 during connecting to a server.
```
  "ConnectionStrings": {
    "DefaultConnection": "Server=.\\SQLEXPRESS;Database=PersonDb;Trusted_Connection=True;MultipleActiveResultSets=True"
  },
```

4.	Run the code using <code>ctrl+F5</code> or clicking <code>IIS EXPRESS</code> run button.
5.	Database should be created automatically but if not created then go to <code>Tools->NuGet Package Manager ->Package Manager Console</code> and after the console opens, run the command <code>update-database</code>. This will create the database in your MS SQL server.
6.	The server will start with swagger where you can try out the apis.

Database Schema
----------------
<b>Persons</b> <br>
↳ Id : int <br>
↳ Name : string <br>
↳ Age : int <br>
↳ Gender : int <br>
↳ DateOfBirth : DateTime <br>
↳ CreatedAt : DateTime <br>
↳ ModifiesAt : DateTime <br>



<!-- USAGE EXAMPLES -->
## Usage
This template is based on Clean Architechture using MediatR and CQRS of an ASP.NET core web api. Using this template anyone can have a ready project and start building their application with the project stucture already built.  

<!-- _For more examples, please refer to the [Documentation](https://example.com)_ -->



<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/MahdiFaheem/Clean-Architecture-MediatR-And-CQRS-Template/issues) for a list of proposed features (and known issues).



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact


<a href="https://linkedin.com/in/mahdifaheem" target="_blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/linked-in-alt.svg" alt="mahdifaheem" height="30" width="40" /></a>
<a href="https://fb.com/mahdifaheem" target="_blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/facebook.svg" alt="mahdifaheem" height="30" width="40" /></a>

Project Link: [https://github.com/MahdiFaheem/Clean-Architecture-MediatR-And-CQRS-Template](https://github.com/MahdiFaheem/Clean-Architecture-MediatR-And-CQRS-Template)


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
<!-- [contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/MahdiFaheem/Clean-Architecture-MediatR-And-CQRS-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/MahdiFaheem/Clean-Architecture-MediatR-And-CQRS-Template/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/mahdifaheem -->
<!-- [product-screenshot]: images/screenshot.png -->
