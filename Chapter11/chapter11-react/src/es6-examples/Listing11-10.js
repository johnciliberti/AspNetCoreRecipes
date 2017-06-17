// import the default export from an external module
// defined as a dependency in package.json
import React from 'react';

// import the several named exports from
// module defined in same directory
import { authorFirstName, authorLastName } from './Listing11-9';

// import the default export as well as several named exports
// from module defined in directory Sub-folder
import customName, { car, bike } from './Subfolder/Module1';

// import the default export as well as all named exports
// from module defined in directory Sub-folder
import customName2, * as mod2 from './Subfolder/Module2';
