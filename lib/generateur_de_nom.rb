module GenerateurDeNom

  class GenerateurDeNom
    FIRSTNAMES = 22705 #number of all lines in firstname.txt -1
    SURNAMES   = 88304 #number of all lines in surnames.txt -1
  
    # Basic initializer
    def initialize()
  
    end
  
    def get_firstname() #returns a string 
      firstname = self.get_line("./data/firstnames.txt", rand(0..FIRSTNAMES)).chomp
      return firstname
    end
  
    def get_surname() #returns a string 
      surname = self.get_line("./data/surnames.txt", rand(0..SURNAMES)).chomp
      return surname
    end
  
    def get_multiple(number) #returns array of strings(ex: [Adam Sandler, Alex Lux, ...])
      array_of_names = Array.new
      for a in 0...number do
        random_name = "#{self.get_firstname} #{self.get_surname}"
        array_of_names.push random_name
      end
      return array_of_names
    end
  
  
    private
  
    def get_line(path, line_number)
      result_line = nil
      
      File.open(path, "r") do |f|
        while line_number > 0
          line_number -= 1
          result_line = f.gets
        end
      end
      
      return result_line
    end
  
  end
end