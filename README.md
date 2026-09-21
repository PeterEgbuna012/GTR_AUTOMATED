# GTR_AUTOMATED

## Overview

GTR_AUTOMATED is a test automation framework designed to support automated testing of GTR railway asset management and maintenance applications. The framework is used for validating business processes, ensuring application quality, and supporting regression testing across multiple GTR modules.

## Repository

**GitHub Repository:**  
🔗 [GTR_AUTOMATED](https://github.com/PeterEgbuna012/GTR_AUTOMATED)

---

## Technology Stack

- C#
- .NET
- Selenium WebDriver
- Reqnroll / SpecFlow BDD
- NUnit
- Playwright (Ongoing Migration)
- Git & GitHub
- Allure Reporting

---

## Framework Structure

```text
GTR_AUTOMATED
│
├── Features
│   ├── Administration
│   ├── Maintenance & Production
│   ├── Materials Management
│   ├── MWE
│   ├── Train_Presentation
│   └── Work Management
│
├── Hooks
│   └── Hooks.cs
│
├── Pages
│   ├── CleanMastPOM.cs
│   ├── CMSSCRIPTSPOM.cs
│   ├── CMWOPOM.cs
│   ├── DEFECTIVEASSETMANAGEMENTPOM.cs
│   ├── EMWOPOM.cs
│   ├── ExpeditingProcessPOM.cs
│   ├── FAULTSPOM.cs
│   ├── InventoryReportsPOM.cs
│   ├── ItemMasterPOM.cs
│   ├── LoginPage.cs
│   ├── PMWOPOM.cs
│   ├── PRPOM.cs
│   ├── SandMasterPOM.cs
│   ├── ScreenshotImageFormat.cs
│   ├── TakeScreenShotPOM.cs
│   ├── TCPOM.cs
│   ├── WorkOrderTrackingReportsPOM.cs
│   └── YardMasterPOM.cs
│
├── StepDefinitions
│   ├── CleanMasterStepDefinitions.cs
│   ├── CMSScriptsStepDefinitions.cs
│   ├── CMWorkOrderStepDefinitions.cs
│   ├── DefectiveAssetManagementStepDefinitions.cs
│   ├── EMWorkOrderStepDefinitions.cs
│   ├── ExpeditingProcessStepDefinitions.cs
│   ├── FaultsStepDefinitions.cs
│   ├── InventoryReportsStepDefinitions.cs
│   ├── ItemMasterStepDefinitions.cs
│   ├── PMWorkOrderStepDefinitions.cs
│   ├── PRStepDefinitions.cs
│   ├── SandMasterUnitsAndSandboxesStepDefinitions.cs
│   ├── ToiletCheckerStepDefinitions.cs
│   ├── WorkOrderTrackingReportsStepDefinitions.cs
│   └── YardMasterStepDefinitions.cs
│
├── Utilities
│   ├── AllureLogger.cs
│   ├── SafeActions.cs
│   └── SeleniumWaits.cs
│
├── Configuration
│   ├── allureConfig.Template.json
│   ├── graph.json
│   └── .editorconfig
│
├── Dependencies
│
├── node_modules
│
├── package.json
├── package-lock.json
├── packages.txt
├── .gitattributes
├── .gitignore
└── README.md
```
| Layer               | Purpose                                                                     |
| ------------------- | --------------------------------------------------------------------------- |
| **Features**        | Contains BDD feature files grouped by business area.                        |
| **Pages**           | Page Object Model (POM) classes encapsulating UI interactions and locators. |
| **StepDefinitions** | Maps Gherkin steps to automation code implementation.                       |
| **Hooks**           | Test setup and teardown logic executed before and after scenarios.          |
| **Utilities**       | Common reusable helper methods, waits, logging, and framework utilities.    |
| **Configuration**   | Framework configuration files and test settings.                            |
| **Dependencies**    | NuGet and Node.js package dependencies required by the framework.           |


## Key Capabilities

- Business Rule Validation
- End-to-End Testing
- Regression Testing
- Smoke Testing
- Data-Driven Testing
- Cross-Application Integration Testing
- Automated Execution and Reporting

---

## Supported Test Modules

The framework currently supports automation for:

- Fleet Master
- Slot Management
- Work Order Tracking
- Mobile Work Execution (MWE)
- Depot Operations
- Asset Management
- Road Management
- Work Management
- Maintenance And Production
- Purchasing And Receiving
- Defective Asset Management
- Inventory Reports
- Work Order Report
- Toilet Checker
- Clean Master
- CMS
- Sand Master
- Yard Master
- Inventory Management
- Reporting Modules
- Expediting Process


---

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/PeterEgbuna012/GTR_AUTOMATED.git
```

### Navigate to the Project

```bash
cd GTR_AUTOMATED
```

### Restore Dependencies

```bash
dotnet restore
```

### Build the Solution

```bash
dotnet build
```

### Execute Tests

```bash
dotnet test
```

---

## Test Reporting

### Generate Allure Report

```bash
dotnet test

allure generate allure-results --clean -o allure-report
```

### Open Allure Report

```bash
allure open allure-report
```

---

## Branch Strategy

| Branch | Purpose |
|----------|----------|
| `master` | Production-ready code |
| `Release.*` | Release-specific testing |
| `feature/*` | New feature development |
| `bugfix/*` | Defect fixes |

---

##*Contributing

1. Create a feature *ranch.
2. Implement and test chang*s.
3. Commit using meaningful comm*t messages.
4. Push changes to Git*ub.
5. Create a Pull Request.
6. R*solve merge conflicts before mergi*g.
7. Ensure all automated tests p*ss.

---

## Best Practices

- Kee* feature files business-focused.
-*Follow BDD naming conventions.
- R*use Page Object methods wherever p*ssible.
- Maintain test independen*e.
- Use dynamic and reusable loca*ors.
- Review pull requests before*merging.
- Resolve all Git merge c*nflicts before committing.
- Ensur* all tests pass before creating a *ull Request.

---

## Common Git C*mmands

### Pull Latest Changes

`*`bash
git pull origin master
```

*## Create a New Branch

```bash
gi* checkout -b feature/my-feature
``*

### Commit and Push Changes

```*ash
git add .
git commit -m "Descr*ption of changes"
git push origin *eature/my-feature
```

---

## Maintainer

**Peter Egbuna**  
QA Consultant

---

## Disclaimer

This repository contains automation assets intended for quality assurance, testing, and validation activities. Usage, modification, and distribution should comply with project governance, security requirements, and organizational standards.

