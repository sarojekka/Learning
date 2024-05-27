const { app } = require('@azure/functions');
let totalhitcount =0;

app.http('httpTrigger1', {
    methods: ['GET', 'POST'],
    authLevel: 'anonymous',
    handler: async (request, context) => {
        context.log(`Http function processed request for url "${request.url}"`);

        const name = request.query.get('name') || await request.text() || 'world';
        totalhitcount = totalhitcount + 1    
        return { body: `Hello, ${name}!, Total hit count is :` + totalhitcount };
    }
});
