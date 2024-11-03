describe('Delfi Website Tests', () => {
  
  // Test, mis kontrollib, kas lehe pealkiri sisaldab "Delfi" - see peaks õnnestuma
  it('Should display Delfi title', () => {
    cy.visit('https://www.delfi.ee/'); // Külastab Delfi lehte
    cy.title().should('include', 'Delfi'); // Kontrollib, kas pealkiri sisaldab "Delfi"
  });

  // Test, mis kontrollib, kas menüüs on "Meelelahutus" link - see peaks ebaõnnestuma
  it('Should fail because menu link "Film" does not exist', () => {
    cy.visit('https://www.delfi.ee/'); // Külastab Delfi lehte
    cy.contains('Film').should('be.visible'); // Kontrollib, kas lehel on nähtav link "Film"
  });

});
