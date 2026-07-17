# GTR_AUTOMATED

A comprehensive BDD (Behavior-Driven Development) test automation suite for GTR (likely a MAXIMO-based enterprise application), built with C# and Selenium WebDriver using the Reqnroll (formerly SpecFlow) framework.

## What This Is

GTR_AUTOMATED is an automated testing solution that validates core business processes across multiple modules of a MAXIMO-based system. It uses Gherkin feature files to define test scenarios in plain English, making tests readable and maintainable by both technical and non-technical stakeholders. The framework executes these tests through Selenium WebDriver with comprehensive logging via Allure reporting.

### Stack

- **Language(s):** C# (82.3%), Gherkin/Cucumber (17.7%)
- **Framework / runtime:** .NET 10.0 + Reqnroll 3.3.4 + Selenium WebDriver 4.46
- **Key libraries:**
  - **Reqnroll** (3.3.4) — BDD framework for Gherkin feature execution
  - **Selenium WebDriver** (4.46) — Browser automation
  - **NUnit** (5.0.0-beta.1) — Test runner
  - **Allure** (2.15.0) — Test reporting and logging
  - **Entity Framework Core** (10.0.10) — Database access (optional)

## How It's Organized

```
GTR_AUTOMATED/
├── Features/                          Gherkin feature files (test scenarios)
│   ├── Administration/
│   │   └── CMS Scripts/               CMS-related features
│   ├── MWE/                          Materials/Work/Equipment features
│   ├── Maintenace & Production/       Maintenance & production workflows
│   ├── Materials Management/          Materials/inventory management
│   ├── Materials/                     Material-specific features
│   ├── Train_Presentation/            Training presentation features
│   └── Work Management/               Work order & scheduling features
│
├── StepDefinitions/                   Step implementations (C#)
│   ├── CMSScriptsStepDefinitions.cs   CMS-related step bindings
│   ├── CMWorkOrderStepDefinitions.cs  Corrective maintenance work orders
│   ├── PMWorkOrderStepDefinitions.cs  Preventive maintenance work orders
│   ├── EMWorkOrderStepDefinitions.cs  Emergency maintenance work orders
│   ├── YardMasterStepDefinitions.cs   Yard master operations
│   ├── ItemMasterStepDefinitions.cs   Item/inventory master data
│   ├── ToiletCheckerStepDefinitions.cs Toilet Checkers operations
│   ├── ExpeditingProcessStepDefinitions.cs
│   ├── PRStepDefinitions.cs           Purchase requisition workflows
│   ├── WorkOrderTrackingReportsStepDefinitions.cs
│   ├── InventoryReportsStepDefinitions.cs
│   ├── FaultsStepDefinitions.cs
│   ├── DefectiveAssetManagementStepDefinitions.cs
│   ├── CleanMasterStepDefinitions.cs  Clean Master (MXR) operations
│   └── SandMasterUnitsAndSandboxesStepDefinitions.cs
│
├── Pages/                             Page Object Model (POM) classes
│   ├── LoginPage.cs                  Login workflow
│   ├── CMSSCRIPTSPOM.cs              CMS Scripts page objects
│   ├── CMWOPOM.cs                    Corrective maintenance WO
│   ├── PMWOPOM.cs                    Preventive maintenance WO
│   ├── EMWorkOrderPOM.cs             Emergency maintenance WO
│   ├── YardMasterPOM.cs              Yard master page objects
│   ├── ItemMasterPOM.cs              Item master page objects
│   ├── ToiletCheckerPOM.cs
│   ├── TCPOM.cs
│   ├── ExpeditingProcessPOM.cs
│   ├── PRPOM.cs                      Purchase requisition
│   ├── WorkOrderTrackingReportsPOM.cs
│   ├── InventoryReportsPOM.cs
│   ├── FAULTSPOM.cs
│   ├── DEFECTIVEASSETMANAGEMENTPOM.cs
│   ├── CleanMastPOM.cs               Clean Master page objects
│   ├── SandMasterPOM.cs
│   ├── TakeScreenShotPOM.cs          Screenshot utility
│   └── ScreenshotImageFormat.cs
│
├── Hooks/                             Test lifecycle hooks
│   └── Hooks.cs                      Setup (driver init), teardown (screenshots on failure)
│
├── Utilities/                         Shared utilities
│   ├── AllureLogger.cs               Allure reporting integration
│   ├── SafeActions.cs                Safe Selenium action wrappers
│   └── SeleniumWaits.cs              Explicit waits utilities
│
├── Config/
│   └── appsettings.json             Configuration (copied to output)
│
├── GTR_AUTOMATED.csproj             .NET project file (package references)
├── GTR_AUTOMATED.sln                Solution file
└── packages.txt                     External package tracking
```

### How It Fits Together

1. **Feature Files** → Define user-facing test scenarios in Gherkin (Given/When/Then).
2. **Step Definitions** → C# methods bind to Gherkin steps and execute test logic.
3. **Page Objects** → Encapsulate Selenium interactions and element selectors for each UI section.
4. **Hooks** → Initialize Chrome WebDriver before each scenario, take failure screenshots, tear down after tests.
5. **Utilities** → Provide logging (Allure), safe waits, and action wrappers.
6. **NUnit + Reqnroll** → Runner executes features; Allure captures results and generates HTML reports.

## How to Run It

### Prerequisites

- **.NET 10.0 SDK** or later
- **Visual Studio 2022** (recommended) or Visual Studio Code
- **Chrome browser** (tests target Chrome via WebDriver)
- **Test environment access:** `https://gtrtest.eams-cloud.com/maximo/webclient/login/login.jsp`

### From Visual Studio

1. **Open the solution:**
   ```bash
   GTR_AUTOMATED.sln
   ```

2. **Restore NuGet packages:**
   ```
   dotnet restore
   ```

3. **Run all tests:**
   - Test → Run All Tests (Ctrl+R, A)
   - Or via Test Explorer: View → Test Explorer → Run All

4. **Run a specific feature:**
   - Right-click a `.feature` file → Run (Reqnroll extension)

### From Command Line

```bash
# Restore dependencies
dotnet restore

# Build
dotnet build

# Run all tests
dotnet test

# Run tests with NUnit (verbose)
dotnet test --logger "console;verbosity=detailed"

# Generate Allure report (after test run)
allure serve allure-results
```

### Test Configuration

Tests use Chrome in **incognito mode** by default:
- Base URL: `https://gtrtest.eams-cloud.com`
- Profile preferences disable credential manager prompts
- Screenshots captured on test failure (saved to `allure-results/`)

## Key Features

- **BDD-style scenarios** — Human-readable test definitions in Gherkin
- **Page Object Model** — Centralized UI element selectors and interactions
- **Allure reporting** — Rich HTML test reports with screenshots, logs, and trends
- **Implicit driver management** — Reqnroll dependency injection handles WebDriver lifecycle
- **Error screenshots** — Failed tests auto-capture browser state
- **Multi-module coverage:**
  - Work order management (corrective, preventive, emergency)
  - Item/inventory master data
  - Purchase requisitions
  - Yard master operations
  - CMS scripts and training
  - Defective asset management
  - Reports and expediting

## Project Structure Notes

- **Features/** — One subdirectory per module. Feature files follow naming convention: `<feature>.feature`
- **StepDefinitions/** — One class per feature module; each `[StepDefinition]` method corresponds to a Gherkin line
- **Pages/** — One POM class per major UI section; methods encapsulate element finding and interactions
- **Hooks/Hooks.cs** — Centralized setup/teardown; initializes Chrome, manages screenshots, logs to Allure

## Troubleshooting

### Tests hang or fail to connect
- Verify VPN/network access to `https://gtrtest.eams-cloud.com`
- Check Chrome browser is installed and compatible with WebDriver version
- Review `allure-results/` for failure screenshots

### Reqnroll feature not recognized
- Ensure Reqnroll extension is installed in Visual Studio
- Right-click `.feature` file → Properties → Custom Tool: `RqsGherkinRxamlGenerator`

### Allure report not generating
- Run tests before generating report: `dotnet test`
- Install Allure CLI: `npm install -g allure-commandline`
- Generate: `allure serve allure-results`

## Try Asking

- **What tests are available in the YardMaster module?** → Explore `Features/Maintenace & Production/` and `YardMasterStepDefinitions.cs`
- **How do I add a new test scenario?** → Create a `.feature` file in the appropriate feature folder, then add step definitions in `StepDefinitions/`
- **How can I run only Corrective Maintenance work order tests?** → Filter by feature or tag in the test runner (Reqnroll supports `@tag` filtering)

---

**Repository:** [PeterEgbuna012/GTR_AUTOMATED](https://github.com/PeterEgbuna012/GTR_AUTOMATED)  
**Language:** C# (.NET 10.0)  
**License:** (Not specified; add if applicable)
