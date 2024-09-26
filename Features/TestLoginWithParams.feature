@Sanity
Feature: TestLoginWithParams


Test login with test data parameters

Background: 
Given User is on login page

Scenario: Verify login functionality
When User enters the username and password
And User clicks on login button
Then User is navigated to home page


Scenario Outline: Verify login with test parameters
	When User enters the "<username>" and "<password>"
	And User clicks on login button
	Then User is navigated to home page
	Then User selected city and country information
	| city   | country |
	| delhi  | India   |
	| Boston | Usa     |

Examples: 
| username | password |
| tom      | Harry    |
| jerry    | Mathew   |
