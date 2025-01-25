# Selenium Automation Framework with SpecFlow and C for Jama Website#

## Overview
This project is an automation testing framework built with **Selenium**, **SpecFlow**, and **C#**. It adheres to best practices such as the Page Object Model (POM), reusable components, and modular design to ensure maintainability and scalability.

## Features
- **Selenium WebDriver** for browser automation.
- **SpecFlow** for Behavior-Driven Development (BDD).
- Dynamic handling of locators and waits.
- Centralized configuration via `appsettings.json`.
- Extensible architecture for scalability.

## Project Structure
```plaintext
JamaAutomationFramework
├── Features          # SpecFlow feature files
│   ├── Login.feature
    ├── Stream.feature
├── Steps             # Step definitions for SpecFlow scenarios
│   ├── LoginSteps.cs
├── Pages             # Page Object Model (POM) classes
│   ├── BasePage.cs
│   ├── HomePage.cs
│   ├── LoginPage.cs
│   ├── StreamPage.cs
├── Utilities         # Reusable utilities and helpers
│   ├── DriverManager.cs
│   ├── WaitHelpers.cs
│   ├── ConfigurationManager.cs
│   ├── JavaScriptHelpers.cs
│   ├── StringUtils.cs
├── Hooks             # SpecFlow hooks for test lifecycle management
│   ├── SpecFlowHooks.cs
├── appsettings.json  # Configuration file
├── README.md         # Project documentation (this file)
```

## Prerequisites
- **Visual Studio 2022** or higher.
- **.NET 6 SDK** or higher.
- SpecFlow extension for Visual Studio.
- NuGet packages:
  - `Selenium.WebDriver`
  - `Selenium.WebDriver.ChromeDriver`
  - `Selenium.Support`
  - `SpecFlow.NUnit`
  - `SpecFlow.Tools.MsBuild.Generation`
  - `DotNetSeleniumExtras.WaitHelpers`

## Setup
1. Open the project in **Visual Studio**.
2. Install the required NuGet packages (if not already installed):
   ```bash
   Install-Package Selenium.WebDriver
   Install-Package Selenium.WebDriver.ChromeDriver
   Install-Package Selenium.Support
   Install-Package SpecFlow.NUnit
   Install-Package SpecFlow.Tools.MsBuild.Generation
   Install-Package DotNetSeleniumExtras.WaitHelpers
   ```
3. Update `appsettings.json` with your application-specific configurations:
   ```json
   {
       "BaseUrl": "https://example.com",
       "Credentials": {
           "Username": "testuser",
           "Password": "password123"
       }
   }
   ```

## Running Tests
1. Build the project to ensure there are no compilation errors.
2. Run SpecFlow tests:
   - **From Visual Studio**: Right-click a `.feature` file and select **Run SpecFlow Scenarios**.
   - **Using the Test Explorer**: Open Test Explorer and run tests.

## Key Components

### Dynamic Locators
The framework supports dynamically generating locators based on parameters:
```csharp
 public List<By> GetCommentsList(string text)
 {
    return new List<By>
    {
        By.XPath($"//div[@class='js-root-comment-text-wrapper']/p[text()='{text}']")
    };
 }
```

### Wait Helpers
Centralized utility to handle explicit waits:
```csharp
public static IWebElement WaitForElementToBeVisible(IWebDriver driver, By locator, int timeoutInSeconds = 10)
{
    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
    return wait.Until(ExpectedConditions.ElementIsVisible(locator));
}
```

### Configuration Management
Configuration values are managed in `appsettings.json` and accessed dynamically:
```csharp
public static string GetValue(string key)
{
    return _configuration[key];
}
```

### SpecFlow Features
Example feature file for stream functionality:
```gherkin
Feature: Stream Functionality

Jama Stream test scenarios

  Scenario: Add a Comment Validation
    Given I am on the login page
    When I enter valid credentials
    And I navigate to Stream Page
    Then I validate a comment is correctly added
```

## Best Practices
- **Page Object Model**: Encapsulate web element locators and actions in dedicated classes.
- **Reusable Waits**: Use centralized wait logic to ensure consistent and reliable interactions.
- **Dynamic Locators**: Generate locators dynamically based on runtime parameters to handle variable scenarios.
- **Environment Configuration**: Use `appsettings.json` or environment variables to manage test data and URLs.
- **Avoid Hardcoding**: Centralize and parameterize configurations to make tests maintainable.

## Contact
For any questions or feedback, please contact ingrodolfopacheco@gmail.com