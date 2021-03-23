Discussion for incomplete requirements:

### Requirement 2: (specifically the confirmation page)
I would have implemented the confirmation functionality by adding code to the ContractsController that would redirect to a separate ConfirmationPage on submission if all validation succeeded.

Before realizing a Redirect in the controller action would have a simpler solution, I was in the process of implementing the contact submission form through a RESTful POST endpoint on the ContactsController. However, I realized this could not directly issue a redirect to the confirmation page as it would already be returning 201 Created on success. 

Also, given that this was being used for a form in Razor and not a separate web API, in retrospect, my implementation idea was slightly offmark especially since it isn't a "resource" from the user's perspective.

### Requirement 7:
For unit testing, I could have created unit tests for testing the logic in the ContactsController and isolated its behavior by mocking the ContactService with a library like Moq. Additionally, I could have created integration tests for the ContactService.
