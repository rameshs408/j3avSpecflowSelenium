Feature: NonChromeBrowser
	Testing Non chrome browsers

@ToDoApp
Scenario: Add items to the ToDoApp - Firefix
	Given I navigate to j3av App on following environment
		| Browser | BrowserVersion | OS         |
		| Firebox | 84.0           | Windows 10 |
	And I select the first item
	And I select the second item
	And I enter new value in textbox
	When I click the Submit button
	Then I verify whether the item is added to the list