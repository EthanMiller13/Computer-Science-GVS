.MODEL small
.STACK 100h      
.DATA
    charToGuess db ?
    guessedChar db ?
    msg1 db 13, 10, 'Enter your guess: $'
    wonMsg db 13, 10, 'You won!', 13, 10, '$'
    lossMsg db 13, 10, 'You lost, you can try again', 13, 10, '$'
    finalMsg db 13, 10, 'The char was: $'
    
    clock equ 40h:6ch
.CODE
    mov ax, @data
    mov ds, ax
    
    mov ah, 2ch
    int 21h
    and dl, 00001111b
    add dl, 41h
    mov charToGuess, dl
    
    xor ax, ax
    
    xor cx, cx
    mov cx, 3
        
guess:
    lea dx, msg1
    mov ah, 09h
    int 21h
    
    mov ah, 1h
    int 21h
    mov guessedChar, al
    
    mov bl, guessedChar
    cmp bl, charToGuess
    je win
    jne loss
    
win:
    lea dx, wonMsg
    mov ah, 09h
    int 21h
    jmp exit
    
loss:
    lea dx, lossMsg
    mov ah, 09h
    int 21h
    loop guess    
    jmp exit

    
exit:
   lea dx, finalMsg
   mov ah, 09h
   int 21h
   
   mov dl, charToGuess
   mov ah, 02h
   int 21h
   
   mov ah, 4Ch
   int 21h
      
END