This repo shows an example of how to introduce testability to a legacy app that was not designed with testing in mind.

The intention is NOT to create a perfect architecture, but to work with the existing one to introduce testing with minimal changes, in order to facilitate future refactoring.

## The app

This is a simple .Net 4.8 console app that calls boredapi to get a suggestion for something to do.

## Before
checkout tag `BEFORE`

Shows the app manually instantiating the client.

## After
checkout tag `AFTER`
Shows the app with test override injection implemented.