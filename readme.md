# Selenium Lab Project with .NET 8 and C#

This is a lab project developed in C# using the Selenium framework, aimed at demonstrating Selenium Manager, WebDriver configuration and different approaches to organizing Page Objects, Actions, and Assertions.

<table>
    <tr>
        <td><img src="https://softwarereviews.s3.amazonaws.com/production/favicons/offerings/7361/original/1_v7l9L2x3DkOzcnAhDbYNmQ.png" width="30" /></td>
        <td><img src="https://cdn.iconscout.com/icon/free/png-256/free-csharp-1175240.png?f=webp" width="30" /></td>
        <td><img src="https://cdn.lo4d.com/t/icon/128/microsoft-net-core.png" width="30" /></td>
        <td><img src="https://avatars.githubusercontent.com/u/2678858?s=280&v=4" width="30" /></td>
        <td><img src="https://cdn.iconscout.com/icon/free/png-256/free-docker-logo-icon-download-in-svg-png-gif-file-formats--technology-social-media-vol-2-pack-logos-icons-3029959.png" width="30" /></td>
    	<td><img src="https://github.githubassets.com/images/modules/logos_page/GitHub-Mark.png" width="30" /></td>
    </tr>
</table>

---

## WebDriver Configuration 🌐

The WebDriver has been configured to support multiple browsers, including Chrome, Edge, and Firefox. Execution options can be set through environment variables, allowing for easy configuration of the execution environment (local or in CI/CD).

---

## CI/CD Configuration 🛠️
This project is also configured with GitHub Workflow for continuous integration and Docker for containerization, allowing for a streamlined development and deployment process. This setup ensures that your tests run consistently across different environments, making it easier to maintain and scale your project as needed.

---

## Organizational Approaches 🗂️

In this project, I present two different ways to organize Page Objects, Actions, and Assertions.

### Approach: Hybrid Screenplay Model 🎭

This approach combines the strengths of both the Page Object Model and the Screenplay pattern, promoting readability and maintainability while making it easier to implement. It emphasizes clear communication of test intentions, making it accessible for QA professionals with varying levels of experience.

#### Advantages:
- **Improved Readability:** Test code reads like natural language, making it easier for all team members to understand the test flow.
- **Ease of Maintenance:** Changes in UI or test logic require fewer modifications in test code due to a more modular design.
- **Better Collaboration:** This approach fosters better communication between developers and QAs by providing a clear structure.

---

## How to Run on Windows Powershell 💻

```bash
$env:Run = "true"; $env:Browser = "Chrome"; dotnet test
```
## With Log 📜

```bash
$env:Run = "true"; $env:Browser = "Chrome"; dotnet test --logger "console;verbosity=detailed"
```

## Run on MacOS Terminal 🍏
```bash
export Run="true"; export Browser="Chrome"; dotnet test
```

---

# Bonus Section 🎉
### How to Set Up a Selenium Project on .NET 8 - Easy Step-By-Step Guide 🛠️

Follow the steps below to create a SeleniumLab project similar to this one:

### Step 1: Create a New Project 🚀

Run the following command to create a new console project:

```bash
	dotnet new console -n SeleniumLab
```
### Step 2: Add Required Dependencies 📦

Add the necessary packages for Selenium and NUnit functionality:

```bash
	dotnet add package Microsoft.NET.Test.Sdk
	dotnet add package NUnit 
	dotnet add package NUnit3TestAdapter
	dotnet add package Selenium.WebDriver 
```

### Step 3: Restore Dependencies 🔄

Restore the project's dependencies to ensure everything is up to date:
```bash
	dotnet restore
```

### Additional Tips 💡
- **Design Pattern Choice**: Select your design pattern thoughtfully, take into account the tools you'll be using, the types of tests you'll develop, and the specific characteristics of your project and team. This will help ensure a smoother workflow and better collaboration.
- **WebDriver Configuration**: Don't forget to configure the WebDriver you want to use.
- **Writing Tests**: Create your test classes using NUnit to ensure your features are working correctly.

Now you're ready to start testing your application with Selenium!