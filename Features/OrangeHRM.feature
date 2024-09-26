Feature: OrangeHRM

Test orange hrm website funcitonality

@tag1
Scenario: Verify  login for orange hrm website
	Given User is on the orange hrm login page
	When User enters the "<username>" and "<password>" in the text fields
	When User clicks on the submit button
	Then User is navigated to the home page

	Examples: :
	| username | password |
	| Admin    | admin123 |


Scenario: Verify Inavlid login for Orange HRM Website
	Given User is on the orange hrm login page
	When User enters the "<user>" and "<pass>" in the text fields
	When User clicks on the submit button
	Then User is displayed with error message

Examples: 
	| user  | pass    |
	| ssjj | vaahaha |
 

